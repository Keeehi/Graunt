using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace graunt
{
    public class CsvParser
    {
        private string data;
        private char recordSeparator;
        private char fieldSeparator;
        private char textDelimiter;
        private bool hasHeader;

        //This inner class implements deterministic finite automaton for parsing DSV format
        private class DFA
        {
            public enum State { Final, NonFinal, Fail };
            private enum InnerState { Final, StateA, StateB, StateC, Fail };
            private InnerState innerState;
            private char recordSeparator;
            private char fieldSeparator;
            private char textDelimiter;

            public DFA(char recordSeparator, char fieldSeparator, char textDelimiter)
            {
                this.innerState = InnerState.Final;
                this.recordSeparator = recordSeparator;
                this.fieldSeparator = fieldSeparator;
                this.textDelimiter = textDelimiter;
            }

            public State Next(char c)
            {
                switch (this.innerState)
                {
                    case InnerState.Final:
                        if (c == this.textDelimiter)
                        {
                            this.innerState = InnerState.StateA;
                            return State.NonFinal;
                        }
                        else if (c == this.recordSeparator || c == this.fieldSeparator)
                        {
                            this.innerState = InnerState.Final;
                            return State.Final;
                        }
                        else
                        {
                            this.innerState = InnerState.StateC;
                            return State.NonFinal;
                        }

                    case InnerState.StateA:
                        if (c == this.textDelimiter)
                        {
                            this.innerState = InnerState.StateB;
                            return State.NonFinal;
                        }
                        else
                        {
                            this.innerState = InnerState.StateA;
                            return State.NonFinal;
                        }

                    case InnerState.StateB:
                        if (c == this.textDelimiter)
                        {
                            this.innerState = InnerState.StateA;
                            return State.NonFinal;
                        }
                        else if (c == this.recordSeparator || c == this.fieldSeparator)
                        {
                            this.innerState = InnerState.Final;
                            return State.Final;
                        }
                        else
                        {
                            this.innerState = InnerState.Fail;
                            return State.Fail;
                        }

                    case InnerState.StateC:
                        if (c == this.textDelimiter)
                        {
                            this.innerState = InnerState.Fail;
                            return State.Fail;
                        }
                        else if (c == this.recordSeparator || c == this.fieldSeparator)
                        {
                            this.innerState = InnerState.Final;
                            return State.Final;
                        }
                        else
                        {
                            this.innerState = InnerState.StateC;
                            return State.NonFinal;
                        }

                    case InnerState.Fail:
                    default:
                        this.innerState = InnerState.Fail;
                        return State.Fail;
                }


            }
        }

        public CsvParser(string input, char recordSeparator, char fieldSeparator, char textDelimiter, bool hasHeader)
        {
            if (recordSeparator == '\0' || fieldSeparator == '\0') 
            {
                throw new CsvParserException(Language.GetString("parser.emptyCharactersError"));
            }

            if (recordSeparator == fieldSeparator || recordSeparator == textDelimiter || fieldSeparator == textDelimiter)
            {
                throw new CsvParserException(Language.GetString("parser.sameCharacterError"));
            }

            data = input;
            this.recordSeparator = recordSeparator;
            this.fieldSeparator = fieldSeparator;
            this.textDelimiter = textDelimiter;
            this.hasHeader = hasHeader;

            if (string.IsNullOrEmpty(input) || data[data.Length - 1] != recordSeparator)
            {
                data += recordSeparator;
            }
        }

        //DFA runs within the scope of this method. According to states of DFA is filled CsvParserResult with parsed data.
        public CsvParserResult GetData()
        {
            DFA dfa = new DFA(this.recordSeparator, this.fieldSeparator, this.textDelimiter);

            bool firstLine = true;
            string field = "";

            int columns = 0;       // počet sloupců (od 1)
            int originalColumnNames = 0; //počet jmen sloupců nalezených v datech
            int currentColumn = 0; // index aktuální buňky (od 0)
            int rows = 0;         // počet řádků (od 1)
            List<string> columnNames = new List<string>();                      // jména sloupců (od 0)
            List<List<string>> cells = new List<List<string>>();                 // data (od 0,0)
            List<int> recordsLength = new List<int>();  // délky záznamů


            for (int characterIndex = 0; characterIndex < data.Length; ++characterIndex)
            {
                char c = data[characterIndex];

                if (firstLine)
                {
                    DFA.State s = dfa.Next(c);

                    if (s == DFA.State.Final)
                    {
                        if (this.hasHeader)
                        {
                            string header = this.Sanitize(field);
                            if (string.IsNullOrEmpty(header))
                            {
                                throw new CsvParserException(Language.GetString("parser.emptyHeaderError"));
                            }
                            if (columnNames.IndexOf(header) != -1)
                            {
                                throw new CsvParserException(Language.GetString("parser.columnNameError"));
                            }
                            columnNames.Add(header);
                            cells.Add(new List<string>());
                            ++originalColumnNames;
                        }
                        else
                        {
                            columnNames.Add(Language.GetString("parser.column") + " " + (currentColumn + 1).ToString());
                            List<string> l = new List<string>();
                            l.Add(this.Sanitize(field));
                            cells.Add(l);
                        }

                        ++currentColumn;
                        field = "";

                        if (c == this.recordSeparator)
                        {
                            firstLine = false;

                            if (!this.hasHeader)
                            {
                                recordsLength.Add(currentColumn);
                                ++rows;
                            }

                            columns = currentColumn;
                            currentColumn = 0;

                        }
                    }
                    else if (s == DFA.State.Fail)
                    {
                        throw new CsvParserException(Language.GetString("parser.dataFormatError"));
                    }
                    else
                    {
                        field += c;
                    }
                }
                else
                {
                    DFA.State s = dfa.Next(c);

                    if (s == DFA.State.Final)
                    {
                        if (currentColumn < columns)
                        {
                            cells[currentColumn].Add(this.Sanitize(field));
                        }
                        else
                        {
                            ++columns;
                            if (columnNames.IndexOf(Language.GetString("parser.column") + " " + columns.ToString()) != -1)
                            {
                                throw new CsvParserException(Language.GetString("parser.columnNameError"));
                            }
                            columnNames.Add(Language.GetString("parser.column") + " " + columns.ToString());
                            List<string> l = new List<string>(new string[rows]);
                            l.Add(this.Sanitize(field));
                            cells.Add(l);
                        }

                        ++currentColumn;

                        if (c == this.recordSeparator)
                        {
                            if (currentColumn < columns)
                            {
                                for (int i = currentColumn; i < columns; ++i)
                                {
                                    cells[i].Add(null);
                                }
                            }

                            recordsLength.Add(currentColumn);

                            currentColumn = 0;
                            ++rows;
                        }

                        field = "";
                    }
                    else if (s == DFA.State.Fail)
                    {
                        throw new CsvParserException(Language.GetString("parser.dataFormatError"));
                    }
                    else
                    {
                        field += c;
                    }
                }
            }

            return new CsvParserResult(false, originalColumnNames, columns, rows, new ReadOnlyCollection<string>(columnNames), new ReadOnlyCollection<List<string>>(cells), new ReadOnlyCollection<int>(recordsLength));
        }

        public CsvParserResult GetData(int limit)
        {
            if (limit < 1)
            {
                throw new GeneralException("Limit has to be greather than 0");
            }

            DFA dfa = new DFA(this.recordSeparator, this.fieldSeparator, this.textDelimiter);

            bool firstLine = true;
            string field = "";

            int columns = 0;       // počet sloupců (od 1)
            int currentColumn = 0; // index aktuální buňky (od 0)
            int originalColumnNames = 0; //počet jmen sloupců nalezených v datech
            int rows = 0;         // počet řádků (od 1)
            List<string> columnNames = new List<string>();                      // jména sloupců (od 0)
            List<List<string>> cells = new List<List<string>>();                 // data (od 0,0)
            List<int> recordsLength = new List<int>();  // délky řádků


            for (int characterIndex = 0; characterIndex < data.Length; ++characterIndex)
            {
                char c = data[characterIndex];

                if (firstLine)
                {
                    DFA.State s = dfa.Next(c);

                    if (s == DFA.State.Final)
                    {
                        if (this.hasHeader)
                        {
                            string header = this.Sanitize(field);
                            if (string.IsNullOrEmpty(header))
                            {
                                throw new CsvParserException(Language.GetString("parser.emptyHeaderError"));
                            }
                            if (columnNames.IndexOf(header) != -1)
                            {
                                throw new CsvParserException(Language.GetString("parser.columnNameError"));
                            }
                            columnNames.Add(header);
                            cells.Add(new List<string>());
                            ++originalColumnNames;
                        }
                        else
                        {
                            columnNames.Add(Language.GetString("parser.column") + " " + (currentColumn + 1).ToString());
                            List<string> l = new List<string>();
                            l.Add(this.Sanitize(field));
                            cells.Add(l);
                        }

                        ++currentColumn;
                        field = "";

                        if (c == this.recordSeparator)
                        {
                            firstLine = false;

                            if (!this.hasHeader)
                            {
                                recordsLength.Add(currentColumn);
                                ++rows;

                                if (limit == 1)
                                {
                                    return new CsvParserResult(characterIndex < data.Length - 1, originalColumnNames, columns, rows, new ReadOnlyCollection<string>(columnNames), new ReadOnlyCollection<List<string>>(cells), new ReadOnlyCollection<int>(recordsLength));
                                }
                            }

                            columns = currentColumn;
                            currentColumn = 0;

                        }
                    }
                    else if (s == DFA.State.Fail)
                    {
                        throw new CsvParserException(Language.GetString("parser.dataFormatError"));
                    }
                    else
                    {
                        field += c;
                    }
                }
                else
                {
                    DFA.State s = dfa.Next(c);

                    if (s == DFA.State.Final)
                    {
                        if (currentColumn < columns)
                        {
                            cells[currentColumn].Add(this.Sanitize(field));
                        }
                        else
                        {
                            ++columns;
                            if (columnNames.IndexOf(Language.GetString("parser.column") + " " + columns.ToString()) != -1)
                            {
                                throw new CsvParserException(Language.GetString("parser.columnNameError"));
                            }
                            columnNames.Add(Language.GetString("parser.column") + " " + columns.ToString());

                            List<string> l = new List<string>(new string[rows]);
                            l.Add(this.Sanitize(field));
                            cells.Add(l);
                        }

                        ++currentColumn;

                        if (c == this.recordSeparator)
                        {
                            if (currentColumn < columns)
                            {
                                for (int i = currentColumn; i < columns; ++i)
                                {
                                    cells[i].Add("");
                                }
                            }

                            recordsLength.Add(currentColumn);

                            currentColumn = 0;
                            ++rows;

                            if (rows >= limit)
                            {
                                return new CsvParserResult(characterIndex < data.Length - 1, originalColumnNames, columns, rows, new ReadOnlyCollection<string>(columnNames), new ReadOnlyCollection<List<string>>(cells), new ReadOnlyCollection<int>(recordsLength));
                            }
                        }

                        field = "";
                    }
                    else if (s == DFA.State.Fail)
                    {
                        throw new CsvParserException(Language.GetString("parser.dataFormatError"));
                    }
                    else
                    {
                        field += c;
                    }
                }
            }

            return new CsvParserResult(false, originalColumnNames, columns, rows, new ReadOnlyCollection<string>(columnNames), new ReadOnlyCollection<List<string>>(cells), new ReadOnlyCollection<int>(recordsLength));
        }
        
        //fixing diference of end of lines from different system, stripping text delimiters
        public string Sanitize(string input)
        {
            if (input.Length > 0 && this.recordSeparator == '\n' && input[input.Length - 1] == '\r') 
            {
                input = input.Substring(0, input.Length - 1);
            }

            if (input.Length > 1 && input[0] == this.textDelimiter && input[input.Length - 1] == this.textDelimiter)
            {
                input = input.Substring(1, input.Length - 2);
            }

            return input.Replace(new string(this.textDelimiter, 2), this.textDelimiter.ToString());
        }
    }
}

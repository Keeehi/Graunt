using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace graunt
{
    //This class represents datafile. It uses object serialization for saving data.
    [Serializable]
    public class DataFile : ISerializable
    { 
        private DataTable data;
        private Dictionary<string, string> settings;


        public DataFile() { }
        protected DataFile(SerializationInfo info, StreamingContext context)
        {
            if (info == null) throw new System.ArgumentNullException("info");
            data = (DataTable)info.GetValue("data", typeof(DataTable));
            settings = (Dictionary<string, string>)info.GetValue("settings", typeof(Dictionary<string, string>));
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {
            if (info == null) throw new System.ArgumentNullException("info");
            info.AddValue("data", data);
            info.AddValue("settings", settings);
        }

        public DataTable Data
        {
            get { return data; }
            set { data = value; }
        }
        public Dictionary<string, string> Settings
        {
            get { return settings; }
            set { settings = value; }
        }
    }
    
}

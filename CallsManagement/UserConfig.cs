using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CallsManagement
{
/*    [XmlRootAttribute("UserConfig",
       IsNullable = false)]*/
    public class UserConfig
    {
        public string ConnectionString { get; set; }
        public string Theme { get; set; }
        public string Language { get; set; }

        public string Pallete { get; set; }

 /*       public override string ToString()
        {
            return $"ConnectionsString:{ConnectionString}, Theme:{Theme}, Language: {Language}";
        }*/
    }
}

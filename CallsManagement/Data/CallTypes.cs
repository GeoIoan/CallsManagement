using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace CallsManagement.Data
{
    public class CallTypes : XPLiteObject
    {
        public CallTypes(Session session) : base(session)
        {
        }

        [Key(AutoGenerate = true)]
        public int CallTypeId { get; set; }


        string description;

        public string Description
        {
            get { return description; }
            set { SetPropertyValue(nameof(Description), ref description, value); }
        }


        [Association("CallType-Call")]
        public XPCollection<Call> Calls
        {
            get { return GetCollection<Call>(nameof(Calls)); }
        }
    }

}
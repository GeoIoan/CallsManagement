using DevExpress.Xpo;
using DevExpress.XtraEditors.Filtering;
using System;
using System.ComponentModel;

namespace CallsManagement.Data
{
    public class CallRecievers : XPLiteObject
    {
        public CallRecievers(Session session) : base(session)
        {
        }

        [Key(AutoGenerate = true)]
        public int CallRecieverId { get; set; }


        string name;
        public string Name
        {
            get { return name; }
            set { SetPropertyValue(nameof(Name), ref name, value); }
        }


        [Association("Receiver-Call")]
        public XPCollection<Call> Calls
        {
            get { return GetCollection<Call>(nameof(Calls)); }
        }
    }

}
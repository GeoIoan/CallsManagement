using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Xml.Linq;
using static DevExpress.XtraEditors.RoundedSkinPanel;

namespace CallsManagement.Data
{
    public class CallingContacts : XPLiteObject
    {
        public CallingContacts(Session session) : base(session)
        {
        }

        [Key(AutoGenerate = true)]
        public int CallingContactId { get; set; }

        string name;
        public string Name
        {
            get { return name; }
            set { SetPropertyValue(nameof(Name), ref name, value); }
        }


        string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetPropertyValue(nameof(PhoneNumber), ref phoneNumber, value); }
        }


        [Association("CallingContact-Call")]
        public XPCollection<Call> Calls
        {
            get { return GetCollection<Call>(nameof(Calls)); }
        }
    }
}
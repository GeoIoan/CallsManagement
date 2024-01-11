using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace CallsManagement.Data
{
    [Persistent("Calls")]
    public class Call : XPLiteObject
    {
        public Call(Session session) : base(session)
        {
            
        }
        
        [Key(AutoGenerate = true)]
        public int CallId { get; set; }
        

        DateTime creationDate;
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { SetPropertyValue(nameof(CreationDate), ref creationDate, value); }
        }

        string notes;
        public string Notes
        {
            get { return notes; }
            set { SetPropertyValue(nameof(Notes), ref notes, value); }
        }

        DateTime? modifiedDate;
        public DateTime? ModifiedDate
        {
            get { return modifiedDate; }
            set { SetPropertyValue(nameof(ModifiedDate), ref modifiedDate, value); }
        }


        DateTime callDate = DateTime.Now;
        public DateTime CallDate
        {
            get { return callDate; }

            set {
                  SetPropertyValue(nameof(CallDate), ref callDate, value);               
                }
        }

        CallRecievers recieverId;
        [Association("Receiver-Call"), Persistent("ReceiverId")]
        public CallRecievers RecieverId
        {
            get { return recieverId; }
            set { SetPropertyValue(nameof(RecieverId), ref recieverId, value); }
        }

        //[Persistent("TypeId")]
        CallTypes callTypeId;
        [Association("CallType-Call") , Persistent("TypeId")]
        public CallTypes CallTypeId
        {
            get { return callTypeId; }
            set { SetPropertyValue(nameof(CallTypeId), ref callTypeId, value); }
        }

        CallingContacts callingContactId;
        [Association("CallingContact-Call"), Persistent("CallContactId")]
        public CallingContacts CallingContactId
        {
            get { return callingContactId; }
            set { SetPropertyValue(nameof(CallingContactId), ref callingContactId, value); }
        }

        [NonPersistent]
        public int? CallTypeRowId
        {
            get
            {
                return CallTypeId?.CallTypeId;
            }

            set
            {
                if (value != null)
                    CallTypeId = Session.GetObjectByKey<CallTypes>(value);
            }
        }

        [NonPersistent]
        public int? CallContactRowId
        {
            get
            {
                return CallingContactId?.CallingContactId;
            }

            set
            {
                if (value != null)
                    CallingContactId = Session.GetObjectByKey<CallingContacts>(value);
            }
        }


        [NonPersistent]
        public int? CallReceiverRowId
        {
            get
            {
                return RecieverId?.CallRecieverId;
            }

            set
            {
                if(value != null)
                    RecieverId = Session.GetObjectByKey<CallRecievers>(value);
            }
        }


        [NonPersistent]
        public string CallRecieverName 
        {
            get { return RecieverId?.Name; }             
        }

        [NonPersistent]
        public string CallingContactName
        {
            get { return CallingContactId?.Name; }
        }

        [NonPersistent]
        public string CallTypeDescription
        {
            get { return CallTypeId?.Description; }
        }

        public override string ToString()
        {
            return $"CreationDate: {creationDate}, ModifiedDate: {modifiedDate}, Notes: {notes}, Receiver: {RecieverId}, CallType: {CallTypeId}, CallingContact: {CallingContactId}, CallDate: {CallDate}";
        }

        [NonPersistent]
        public DateTimeOffset? CallDateOffset
        {
            get
            {
                return CallDate;
            }

            set {
                    if (value != null)
                    {
                        CallDate = DateTime.Parse(value.ToString()).ToUniversalTime();
                    }                 
                }
        }

        protected override void OnSaving()
        {
            var isNewObject = this.Session.IsNewObject(this);


            if (isNewObject) CreationDate = DateTime.Now;
            else ModifiedDate = DateTime.Now;
        }
    }

}
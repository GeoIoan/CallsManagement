using CallsManagement.Controls;
using CallsManagement.Data;
using DevExpress.ExpressApp.Editors;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallsManagement
{
    public partial class EditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XPCollection<CallTypes> callTypes;
        XPCollection<CallRecievers> callReceivers;
        XPCollection<CallingContacts> callingContacts;
        bool hasChanges = false;
        DelegateMethod delegateMethod;
        bool isSaved = false;
        bool isReloaded = false;

        Session Session
        {
            get
            {
                return Call?.Session;
            }
        }

        Call Call;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Call call, DelegateMethod delegateMethod)
          : this()
        {
            this.delegateMethod = delegateMethod;
            Call = call;
            Session.TrackPropertiesModifications = true;
            Session.ObjectChanged += Session_ObjectChanged;
        }

        private void Session_ObjectChanged(object sender, ObjectChangeEventArgs e)
        {            
            if (e.Reason == ObjectChangeReason.PropertyChanged)
            {
                hasChanges = true;
                isSaved = false;
                isReloaded = false;
            }           
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            callTypes = new XPCollection<CallTypes>(Session);
            callReceivers = new XPCollection<CallRecievers>(Session);
            callingContacts = new XPCollection<CallingContacts>(Session);

            PopulateParameterControls();
        }

        private void PopulateParameterControls()
        {
            bsiCreationDateContent.DataBindings.Add(new Binding("Caption", Call ,"CreationDate" , false, DataSourceUpdateMode.OnPropertyChanged));

            bsiModifiedDateContent.DataBindings.Add(new Binding("Caption", Call, "ModifiedDate", false, DataSourceUpdateMode.OnPropertyChanged));

            lueCallType.Properties.DisplayMember = "Description";
            lueCallType.Properties.ValueMember = "CallTypeId";
            lueCallType.Properties.DataSource = callTypes;

            lueCallType.DataBindings.Add(new Binding("EditValue", Call, "CallTypeRowId", false, DataSourceUpdateMode.OnPropertyChanged));

            lueCallContact.Properties.DisplayMember = "Name";
            lueCallContact.Properties.ValueMember= "CallingContactId";
            lueCallContact.Properties.DataSource= callingContacts;

            lueCallContact.DataBindings.Add(new Binding("EditValue", Call, "CallContactRowId", false, DataSourceUpdateMode.OnPropertyChanged));

            lueCallReceiver.Properties.DisplayMember = "Name";
            lueCallReceiver.Properties.ValueMember = "CallRecieverId";
            lueCallReceiver.Properties.DataSource = callReceivers;

            lueCallReceiver.DataBindings.Add(new Binding("EditValue", Call, "CallReceiverRowId", false, DataSourceUpdateMode.OnPropertyChanged));

            meNotes.DataBindings.Add(new Binding("EditValue", Call, "Notes", false, DataSourceUpdateMode.OnPropertyChanged));
     
            dtoeCallDate.DataBindings.Add(new Binding("EditValue", Call, "CallDateOffset", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Save();
            delegateMethod.Invoke();
        }

        private void bbiSaveAndExit_ItemClick(object sender, ItemClickEventArgs e)
        {
             if(Save()) DialogResult = DialogResult.OK;
        }

        private bool Save()
        {
            var weAreGood = dxvpEditForm.Validate();

            if (!weAreGood)
            {
                return weAreGood;
            }

            try
            {
                Session.CommitTransaction();
                isSaved = true;
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Localization.ServerError_Msg, Localization.Error_Msg);

                weAreGood = false;
                Session.RollbackTransaction();
            }

            return weAreGood;
        }


        private void NewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((hasChanges && !isSaved && !isReloaded))
            {
                DialogResult dialogResult;

               dialogResult =  XtraMessageBox.Show(Localization.FormClosingWarning_Msg, Localization.Warning_Msg, MessageBoxButtons.YesNoCancel);
               
                switch (dialogResult)
                {
                    case DialogResult.Cancel:
                        {
                            e.Cancel = true;
                            break;
                        }
                    case DialogResult.No:
                        {
                            Session.Reload(Call);
                            e.Cancel = false;
                            break;
                        }
                    case DialogResult.Yes:
                        {
                            if (Save())
                            {
                                e.Cancel = false;
                                DialogResult = DialogResult.OK;
                            }
                            else e.Cancel = true;

                            break;
                        }
                }              
            }
        }

        private void RefreshForm()
        {
            var isNewObject = this.Session.IsNewObject(Call);

            if (isNewObject)
            {
                meNotes.EditValue = null;
                lueCallContact.EditValue = "";
                lueCallReceiver.EditValue = "";
                lueCallType.EditValue = "";
                dtoeCallDate.EditValue = DateTime.Now;
            }
            else Session.Reload(Call);

            isReloaded = true;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (hasChanges && !isReloaded)
            {
                DialogResult dialogResult;

                dialogResult = XtraMessageBox.Show(Localization.RefreshWarning_Msg, Localization.Warning_Msg, MessageBoxButtons.YesNo);

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            RefreshForm();
                            break;
                        }
                    case DialogResult.No:
                        {
                            return;
                        }
                }
            }
        }
    }
}
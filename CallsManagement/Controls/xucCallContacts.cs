using CallsManagement.Data;
using DevExpress.Utils.CommonDialogs.Internal;
using DevExpress.Utils.Extensions;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallsManagement.Controls
{
    public partial class xucCallContacts : DevExpress.XtraEditors.XtraUserControl
    {
        private XPCollection<CallingContacts> xpCollection;
        private UserConfig userConfig;
        UnitOfWork session;

        public xucCallContacts(UserConfig userConfig)
        {
            InitializeComponent();
            this.userConfig = userConfig;

            session = new UnitOfWork();
                     
            populateGrid();
        }

       public void populateGrid()
        {
            xpCollection = new XPCollection<CallingContacts>(session);
            gcCallContacts.DataSource = xpCollection;      
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvCallContacts.ShowEditForm();
            try
            {
                session.CommitTransaction();
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Localization.ServerError_Msg, Localization.Error_Msg);
                session.RollbackTransaction();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xpCollection.Count == 0) return;

            var dialogResult = XtraMessageBox.Show(Localization.Delete_Msg, Localization.Warning_Msg, MessageBoxButtons.YesNo);
            
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                var callContact = gvCallContacts.GetFocusedRow() as CallingContacts;

                callContact.Delete();

                try
                {
                    session.CommitTransaction();
                    Program.GetEventAggregator().RaiseEntityDeletedEvent(this, EventArgs.Empty);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show(Localization.ServerError_Msg, Localization.Error_Msg);
                    session.RollbackTransaction();
                }
            }        
        }

        private void gvCallContacts_EditFormHidden(object sender, DevExpress.XtraGrid.Views.Grid.EditFormHiddenEventArgs e)
        {
            if (e.Result == EditFormResult.Update)
            {
                try
                {
                    session.CommitTransaction();
                    Program.GetEventAggregator().RaiseEntityDeletedEvent(this, EventArgs.Empty);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show(Localization.ServerError_Msg, Localization.Error_Msg);
                    session.RollbackTransaction();
                }
            }
}

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvCallContacts.AddNewRow();
            gvCallContacts.ShowEditForm();
        }

        public void Reload()
        {
            xpCollection.Reload();
            xpCollection.Load();
        }


        private void gvCallContacts_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CallingContacts focusedRow =  gvCallContacts.GetFocusedRow() as CallingContacts;

            if (focusedRow != null && string.IsNullOrEmpty(focusedRow.Name) || string.IsNullOrEmpty(focusedRow.PhoneNumber))
            {
                e.Valid = false;
            }
        }

        private void bbiReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reload();
        }

        private void gvCallContacts_EditFormPrepared(object sender, EditFormPreparedEventArgs e)
        {
            if (Program.GetConfigs().Language == "el")
                e.Panel.ForEachChildControl(c =>
                {
                    if (c.Text == "Update") c.Text = "Ενημέρωση";
                    if (c.Text == "Cancel")
                    {
                        c.Text = "Ακύρωση";
                        return;
                    }                                                 
                });
            else return;
        }

        private void gvCallContacts_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            XtraMessageBox.Show(Localization.InvalidInput_Msg, Localization.Error_Msg);
        }
    }
}

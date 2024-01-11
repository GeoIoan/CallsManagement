using CallsManagement.Data;
using DevExpress.Utils.CommonDialogs.Internal;
using DevExpress.Utils.Extensions;
using DevExpress.Xpo;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.EditForm;
using DevExpress.XtraGrid.EditForm.Helpers;
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
    public partial class xucCallReceivers : DevExpress.XtraEditors.XtraUserControl
    {
        private XPCollection<CallRecievers> xpCollection;
        UnitOfWork session;

        public xucCallReceivers()
        {
            InitializeComponent();

            session = new UnitOfWork();

            populateGrid();
        }

        public void populateGrid()
        {
            xpCollection = new XPCollection<CallRecievers>(session);
            gcCallReceivers.DataSource = xpCollection;
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xpCollection.Count == 0) return;

            gvCallReceivers.ShowEditForm();
            
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

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xpCollection.Count == 0) return;

            var dialogResult = XtraMessageBox.Show(Localization.Delete_Msg, Localization.Warning_Msg, MessageBoxButtons.YesNo);
       
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                var callReceiver = gvCallReceivers.GetFocusedRow() as CallRecievers;

                callReceiver.Delete();

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

        private void gvCallReceivers_EditFormHidden(object sender, DevExpress.XtraGrid.Views.Grid.EditFormHiddenEventArgs e)
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
            gvCallReceivers.AddNewRow();
            gvCallReceivers.ShowEditForm();
        }

        public void Reload()
        {
            xpCollection.Reload();
            xpCollection.Load();
        }


        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CallRecievers focusedRow = gvCallReceivers.GetFocusedRow() as CallRecievers;

            if(focusedRow != null && string.IsNullOrEmpty(focusedRow.Name)) 
            {
                e.Valid = false;
            }
        }

        private void bbiReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reload();
        }

        private void gvCallReceivers_EditFormPrepared(object sender, EditFormPreparedEventArgs e)
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

        private void gvCallReceivers_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            XtraMessageBox.Show(Localization.InvalidInput_Msg, Localization.Error_Msg);
        }
    }
}

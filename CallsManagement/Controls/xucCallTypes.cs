using CallsManagement.Data;
using CallsManagement.Properties;
using DevExpress.ExpressApp;
using DevExpress.Utils.Extensions;
using DevExpress.Xpo;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class xucCallTypes : DevExpress.XtraEditors.XtraUserControl , IDisposable
    {
        XPCollection<CallTypes> xpCollection;
        UnitOfWork session;

        public xucCallTypes()
        {
            InitializeComponent();
            this.Disposed += XucCallTypes_Disposed;
            session = new UnitOfWork();

            var page =  this.ribbonControl1.MergedPages.FirstOrDefault();

            populateGrid();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xpCollection.Count == 0) return;

            gvCallTypes.ShowEditForm();
            
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


        public void populateGrid()
        {
            xpCollection = new XPCollection<CallTypes>(session);            

            gcCallTypes.DataSource = xpCollection;           
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvCallTypes.AddNewRow();
            gvCallTypes.ShowEditForm();                        
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xpCollection.Count == 0) return;

            DialogResult dialogResult;

            dialogResult = XtraMessageBox.Show(Localization.Delete_Msg, Localization.Warning_Msg, MessageBoxButtons.YesNo);
   
            if (dialogResult == DialogResult.Yes)
            {
                var callType = gvCallTypes.GetFocusedRow() as CallTypes;

                callType.Delete();

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
     
        private void gvCallTypes_EditFormHidden(object sender, EditFormHiddenEventArgs e)
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

        private void XucCallTypes_Disposed(object sender, EventArgs e)
        {

        }


        public void Reload()
        {
            xpCollection.Reload();
            xpCollection.Load();

        }

        private void bbiReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reload();
        }

        private void gvCallTypes_EditFormPrepared(object sender, EditFormPreparedEventArgs e)
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

        private void gvCallTypes_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            XtraMessageBox.Show(Localization.InvalidInput_Msg, Localization.Error_Msg);
        }

        private void gvCallTypes_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            CallTypes focusedRow = gvCallTypes.GetFocusedRow() as CallTypes;

            if (focusedRow != null && string.IsNullOrEmpty(focusedRow.Description))
            {
                e.Valid = false;
            }
        }
    }
}

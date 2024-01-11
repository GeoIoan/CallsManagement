using CallsManagement.Data;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallsManagement.Controls
{
    public delegate void DelegateMethod();
    public partial class xucCalls : DevExpress.XtraEditors.XtraUserControl
    {
        XPCollection<Call> xpCollection;
        UnitOfWork session;
        DelegateMethod d;
        string totalCallsCaption;
        string incomingCallsCaption;
        string outgoingCallsCaption;

        public xucCalls()
        {
            InitializeComponent();
            session = new UnitOfWork();
            d = Reload;
            
            totalCallsCaption = bsiTotalCalls.Caption;
            incomingCallsCaption = bsiIncomingCallsCount.Caption;
            outgoingCallsCaption = bsiOutgoingCallsCount.Caption;

            populateGrid();

            Program.GetEventAggregator().RegistryDeleted += CallControl_EntityDeleted;
        }

        public void populateGrid()
        {
            xpCollection = new XPCollection<Call>(session);
            gcCalls.DataSource = xpCollection;
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            using (EditForm newForm = new EditForm(new Call(session), d))
            {
                if (newForm.ShowDialog() == DialogResult.OK) Reload();
            }            
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xpCollection.Count == 0) return;

            Call callRow = gvCalls.GetFocusedRow() as Call;

            using (EditForm newForm = new EditForm(callRow, d))
            { 
                newForm.ShowDialog();
            }
        }

        private void gvCalls_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;

            Call callRow = gvCalls.GetFocusedRow() as Call;

            using (EditForm newForm = new EditForm(callRow, d))
            {
                if (newForm.ShowDialog() == DialogResult.OK) Reload();                
            }
        }

        public void Reload()
        {   
            xpCollection.Reload();
            xpCollection.Load();

            PopulateStatusBar();
        }

        public void ReloadForOtherEntities()
        {
            session.DropIdentityMap();

            xpCollection.Reload();
            xpCollection.Load();

            PopulateStatusBar();
        }

        private void CallControl_EntityDeleted(object sender, EventArgs e)
        {
            ReloadForOtherEntities();
        }


        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xpCollection.Count == 0) return;

            DialogResult dialogResult;

            dialogResult = XtraMessageBox.Show(Localization.Delete_Msg, Localization.Warning_Msg, MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                Call callRow = gvCalls.GetFocusedRow() as Call;

                callRow.Delete();

                try 
                { 
                   session.CommitTransaction();
                   PopulateStatusBar();
                } catch (Exception) 
                {
                    XtraMessageBox.Show(Localization.ServerError_Msg, Localization.Error_Msg);
                    session.RollbackTransaction();
                }
            }
        }

        public void SaveLayout()
        {
            var filePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData), "CallsManagement\\myLayout.xml");
            gvCalls.SaveLayoutToXml(filePath);
        }

        private void gvCalls_Layout(object sender, EventArgs e)
        {
            SaveLayout();
        }


        private void xucCalls_Load(object sender, EventArgs e)
        {
            var defaultLayoutfilePath = Path.Combine(Environment.GetFolderPath(
             Environment.SpecialFolder.LocalApplicationData), "CallsManagement\\defaultLayout.xml");
            gvCalls.SaveLayoutToXml(defaultLayoutfilePath);


            var customnLayoutfilePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData), "CallsManagement\\myLayout.xml");

            if (File.Exists(customnLayoutfilePath))
                gvCalls.RestoreLayoutFromXml(customnLayoutfilePath);    
            
            PopulateStatusBar();
        }


        private void gvCalls_ColumnFilterChanged(object sender, EventArgs e)
        { 
            GridView view = sender as GridView;

            if (view.FilterPanelText.ToString().Contains("Εισερχόμενη"))
            {
                bsiOutgoingCallsCount.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                bsiIncomingCallsCount.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bsiTotalCalls.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else if (view.FilterPanelText.ToString().Contains("Εξερχόμενη"))
            {
                bsiIncomingCallsCount.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                bsiOutgoingCallsCount.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bsiTotalCalls.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                bsiTotalCalls.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                bsiOutgoingCallsCount.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                bsiIncomingCallsCount.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        private void PopulateStatusBar()
        {            
            string incomingCallsCount = $"{incomingCallsCaption} {xpCollection.Count(c => c.CallTypeDescription == "Εισερχόμενη")}";
            string outgoingCallsCount = $"{outgoingCallsCaption} {xpCollection.Count(c => c.CallTypeDescription == "Εξερχόμενη")}";
            string totalCalls = $"{totalCallsCaption} {xpCollection.Count}";

            bsiOutgoingCallsCount.Caption = incomingCallsCount;
            bsiIncomingCallsCount.Caption = outgoingCallsCount;
            bsiTotalCalls.Caption = totalCalls;
        }

        private void bbiReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reload();
        }

        private void bbiDefaultLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "CallsManagement\\defaultLayout.xml");
            gvCalls.RestoreLayoutFromXml(filePath);
        }

        private void bsiIncomingCallsCount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}

namespace CallsManagement.Controls
{
    partial class xucCalls
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucCalls));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bsiTotalCalls = new DevExpress.XtraBars.BarStaticItem();
            this.bsiIncomingCallsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bsiOutgoingCallsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDefaultLayout = new DevExpress.XtraBars.BarButtonItem();
            this.rpActions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcCalls = new DevExpress.XtraGrid.GridControl();
            this.gvCalls = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCalldDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colCallingContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCallType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bsiTotalCalls,
            this.bsiIncomingCallsCount,
            this.bsiOutgoingCallsCount,
            this.bbiReload,
            this.bbiDefaultLayout});
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpActions});
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // bbiNew
            // 
            resources.ApplyResources(this.bbiNew, "bbiNew");
            this.bbiNew.Id = 1;
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            resources.ApplyResources(this.bbiEdit, "bbiEdit");
            this.bbiEdit.Id = 2;
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            resources.ApplyResources(this.bbiDelete, "bbiDelete");
            this.bbiDelete.Id = 3;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bsiTotalCalls
            // 
            resources.ApplyResources(this.bsiTotalCalls, "bsiTotalCalls");
            this.bsiTotalCalls.Id = 19;
            this.bsiTotalCalls.Name = "bsiTotalCalls";
            // 
            // bsiIncomingCallsCount
            // 
            resources.ApplyResources(this.bsiIncomingCallsCount, "bsiIncomingCallsCount");
            this.bsiIncomingCallsCount.Id = 20;
            this.bsiIncomingCallsCount.Name = "bsiIncomingCallsCount";
            // 
            // bsiOutgoingCallsCount
            // 
            resources.ApplyResources(this.bsiOutgoingCallsCount, "bsiOutgoingCallsCount");
            this.bsiOutgoingCallsCount.Id = 21;
            this.bsiOutgoingCallsCount.Name = "bsiOutgoingCallsCount";
            this.bsiOutgoingCallsCount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bsiIncomingCallsCount_ItemClick);
            // 
            // bbiReload
            // 
            resources.ApplyResources(this.bbiReload, "bbiReload");
            this.bbiReload.Id = 22;
            this.bbiReload.Name = "bbiReload";
            this.bbiReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReload_ItemClick);
            // 
            // bbiDefaultLayout
            // 
            resources.ApplyResources(this.bbiDefaultLayout, "bbiDefaultLayout");
            this.bbiDefaultLayout.Id = 23;
            this.bbiDefaultLayout.Name = "bbiDefaultLayout";
            this.bbiDefaultLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDefaultLayout_ItemClick);
            // 
            // rpActions
            // 
            this.rpActions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgActions});
            this.rpActions.MergeOrder = 0;
            this.rpActions.Name = "rpActions";
            resources.ApplyResources(this.rpActions, "rpActions");
            // 
            // rpgActions
            // 
            this.rpgActions.ItemLinks.Add(this.bbiNew);
            this.rpgActions.ItemLinks.Add(this.bbiEdit);
            this.rpgActions.ItemLinks.Add(this.bbiDelete);
            this.rpgActions.ItemLinks.Add(this.bbiReload);
            this.rpgActions.ItemLinks.Add(this.bbiDefaultLayout);
            this.rpgActions.Name = "rpgActions";
            resources.ApplyResources(this.rpgActions, "rpgActions");
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiTotalCalls);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiIncomingCallsCount);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiOutgoingCallsCount);
            resources.ApplyResources(this.ribbonStatusBar1, "ribbonStatusBar1");
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            // 
            // gcCalls
            // 
            resources.ApplyResources(this.gcCalls, "gcCalls");
            this.gcCalls.MainView = this.gvCalls;
            this.gcCalls.MenuManager = this.ribbonControl1;
            this.gcCalls.Name = "gcCalls";
            this.gcCalls.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gcCalls.ShowOnlyPredefinedDetails = true;
            this.gcCalls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCalls});
            // 
            // gvCalls
            // 
            this.gvCalls.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCalldDate,
            this.colCallingContact,
            this.colReceiver,
            this.colCallType,
            this.colNotes});
            this.gvCalls.GridControl = this.gcCalls;
            this.gvCalls.GroupCount = 1;
            this.gvCalls.Name = "gvCalls";
            this.gvCalls.OptionsBehavior.Editable = false;
            this.gvCalls.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCalldDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvCalls.ColumnFilterChanged += new System.EventHandler(this.gvCalls_ColumnFilterChanged);
            this.gvCalls.DoubleClick += new System.EventHandler(this.gvCalls_DoubleClick);
            this.gvCalls.Layout += new System.EventHandler(this.gvCalls_Layout);
            // 
            // colCalldDate
            // 
            resources.ApplyResources(this.colCalldDate, "colCalldDate");
            this.colCalldDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colCalldDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colCalldDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCalldDate.FieldName = "CallDate";
            this.colCalldDate.FieldNameSortGroup = "CallDate";
            this.colCalldDate.GroupFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colCalldDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCalldDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.colCalldDate.Name = "colCalldDate";
            // 
            // repositoryItemDateEdit1
            // 
            resources.ApplyResources(this.repositoryItemDateEdit1, "repositoryItemDateEdit1");
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit1.Buttons"))))});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Buttons"))))});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colCallingContact
            // 
            resources.ApplyResources(this.colCallingContact, "colCallingContact");
            this.colCallingContact.FieldName = "CallingContactName";
            this.colCallingContact.Name = "colCallingContact";
            // 
            // colReceiver
            // 
            resources.ApplyResources(this.colReceiver, "colReceiver");
            this.colReceiver.FieldName = "CallRecieverName";
            this.colReceiver.Name = "colReceiver";
            // 
            // colCallType
            // 
            resources.ApplyResources(this.colCallType, "colCallType");
            this.colCallType.FieldName = "CallTypeDescription";
            this.colCallType.Name = "colCallType";
            // 
            // colNotes
            // 
            resources.ApplyResources(this.colNotes, "colNotes");
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcCalls);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 288);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcCalls;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(774, 268);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xucCalls
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xucCalls";
            this.Load += new System.EventHandler(this.xucCalls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
        private DevExpress.XtraGrid.GridControl gcCalls;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCalls;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiver;
        private DevExpress.XtraGrid.Columns.GridColumn colCallType;
        private DevExpress.XtraGrid.Columns.GridColumn colCallingContact;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colCalldDate;
        private DevExpress.XtraBars.BarStaticItem bsiTotalCalls;
        private DevExpress.XtraBars.BarStaticItem bsiIncomingCallsCount;
        private DevExpress.XtraBars.BarStaticItem bsiOutgoingCallsCount;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiReload;
        private DevExpress.XtraBars.BarButtonItem bbiDefaultLayout;
        /*      private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;*/
    }
}

namespace CallsManagement
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bvcCallManagement = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bvccCallsManagement = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbePalletes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sbApplyTheme = new DevExpress.XtraEditors.SimpleButton();
            this.cbeThemes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeLanguages = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLanguages = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciThemes = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPallete = new DevExpress.XtraLayout.LayoutControlItem();
            this.bvtiGeneralParameters = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCalls = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCallReceivers = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCallContanct = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCallTypes = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.rpParameters = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgParameters = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.dmMainForm = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.bmMainForm = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.bvmMainForm = new DevExpress.XtraBars.Ribbon.BackstageViewManager();
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bvcCallManagement)).BeginInit();
            this.bvcCallManagement.SuspendLayout();
            this.bvccCallsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbePalletes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeThemes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLanguages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLanguages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciThemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPallete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // rcMain
            // 
            this.rcMain.ApplicationButtonDropDownControl = this.bvcCallManagement;
            this.rcMain.ExpandCollapseItem.Id = 0;
            this.rcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMain.ExpandCollapseItem,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiCalls,
            this.bbiCallReceivers,
            this.bbiCallContanct,
            this.bbiCallTypes});
            resources.ApplyResources(this.rcMain, "rcMain");
            this.rcMain.MaxItemId = 11;
            this.rcMain.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.rcMain.Name = "rcMain";
            this.rcMain.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.rcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpParameters});
            // 
            // bvcCallManagement
            // 
            this.bvcCallManagement.Controls.Add(this.bvccCallsManagement);
            this.bvcCallManagement.Items.Add(this.bvtiGeneralParameters);
            resources.ApplyResources(this.bvcCallManagement, "bvcCallManagement");
            this.bvcCallManagement.Name = "bvcCallManagement";
            this.bvcCallManagement.OwnerControl = this.rcMain;
            this.bvcCallManagement.SelectedTab = this.bvtiGeneralParameters;
            this.bvcCallManagement.SelectedTabIndex = 0;
            this.bvcCallManagement.VisibleInDesignTime = true;
            // 
            // bvccCallsManagement
            // 
            this.bvccCallsManagement.Controls.Add(this.layoutControl1);
            resources.ApplyResources(this.bvccCallsManagement, "bvccCallsManagement");
            this.bvccCallsManagement.Name = "bvccCallsManagement";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbePalletes);
            this.layoutControl1.Controls.Add(this.sbApplyTheme);
            this.layoutControl1.Controls.Add(this.cbeThemes);
            this.layoutControl1.Controls.Add(this.cbeLanguages);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // cbePalletes
            // 
            resources.ApplyResources(this.cbePalletes, "cbePalletes");
            this.cbePalletes.MenuManager = this.rcMain;
            this.cbePalletes.Name = "cbePalletes";
            this.cbePalletes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbePalletes.Properties.Buttons"))))});
            this.cbePalletes.StyleController = this.layoutControl1;
            // 
            // sbApplyTheme
            // 
            resources.ApplyResources(this.sbApplyTheme, "sbApplyTheme");
            this.sbApplyTheme.Name = "sbApplyTheme";
            this.sbApplyTheme.StyleController = this.layoutControl1;
            this.sbApplyTheme.Click += new System.EventHandler(this.sbApplyTheme_Click);
            // 
            // cbeThemes
            // 
            resources.ApplyResources(this.cbeThemes, "cbeThemes");
            this.cbeThemes.MenuManager = this.rcMain;
            this.cbeThemes.Name = "cbeThemes";
            this.cbeThemes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbeThemes.Properties.Buttons"))))});
            this.cbeThemes.Properties.Items.AddRange(new object[] {
            resources.GetString("cbeThemes.Properties.Items"),
            resources.GetString("cbeThemes.Properties.Items1"),
            resources.GetString("cbeThemes.Properties.Items2")});
            this.cbeThemes.StyleController = this.layoutControl1;
            this.cbeThemes.SelectedIndexChanged += new System.EventHandler(this.cbeThemes_SelectedIndexChanged);
            // 
            // cbeLanguages
            // 
            resources.ApplyResources(this.cbeLanguages, "cbeLanguages");
            this.cbeLanguages.MenuManager = this.rcMain;
            this.cbeLanguages.Name = "cbeLanguages";
            this.cbeLanguages.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbeLanguages.Properties.Buttons"))))});
            this.cbeLanguages.Properties.Items.AddRange(new object[] {
            resources.GetString("cbeLanguages.Properties.Items"),
            resources.GetString("cbeLanguages.Properties.Items1")});
            this.cbeLanguages.StyleController = this.layoutControl1;
            this.cbeLanguages.SelectedIndexChanged += new System.EventHandler(this.cbeLanguages_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLanguages,
            this.emptySpaceItem1,
            this.lciThemes,
            this.layoutControlItem1,
            this.lciPallete});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(355, 416);
            this.Root.TextVisible = false;
            // 
            // lciLanguages
            // 
            this.lciLanguages.Control = this.cbeLanguages;
            this.lciLanguages.Location = new System.Drawing.Point(0, 0);
            this.lciLanguages.Name = "lciLanguages";
            this.lciLanguages.Size = new System.Drawing.Size(335, 24);
            resources.ApplyResources(this.lciLanguages, "lciLanguages");
            this.lciLanguages.TextSize = new System.Drawing.Size(52, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 98);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(335, 298);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciThemes
            // 
            this.lciThemes.Control = this.cbeThemes;
            this.lciThemes.Location = new System.Drawing.Point(0, 24);
            this.lciThemes.Name = "lciThemes";
            this.lciThemes.Size = new System.Drawing.Size(335, 24);
            resources.ApplyResources(this.lciThemes, "lciThemes");
            this.lciThemes.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbApplyTheme;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(335, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciPallete
            // 
            this.lciPallete.Control = this.cbePalletes;
            this.lciPallete.Location = new System.Drawing.Point(0, 48);
            this.lciPallete.Name = "lciPallete";
            this.lciPallete.Size = new System.Drawing.Size(335, 24);
            resources.ApplyResources(this.lciPallete, "lciPallete");
            this.lciPallete.TextSize = new System.Drawing.Size(52, 13);
            // 
            // bvtiGeneralParameters
            // 
            resources.ApplyResources(this.bvtiGeneralParameters, "bvtiGeneralParameters");
            this.bvtiGeneralParameters.ContentControl = this.bvccCallsManagement;
            this.bvtiGeneralParameters.Name = "bvtiGeneralParameters";
            this.bvtiGeneralParameters.Selected = true;
            // 
            // bbiNew
            // 
            resources.ApplyResources(this.bbiNew, "bbiNew");
            this.bbiNew.Id = 1;
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            resources.ApplyResources(this.bbiEdit, "bbiEdit");
            this.bbiEdit.Id = 2;
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            resources.ApplyResources(this.bbiDelete, "bbiDelete");
            this.bbiDelete.Id = 3;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiCalls
            // 
            resources.ApplyResources(this.bbiCalls, "bbiCalls");
            this.bbiCalls.Id = 4;
            this.bbiCalls.Name = "bbiCalls";
            this.bbiCalls.Tag = "Calls";
            this.bbiCalls.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonParameters_ItemClick);
            // 
            // bbiCallReceivers
            // 
            resources.ApplyResources(this.bbiCallReceivers, "bbiCallReceivers");
            this.bbiCallReceivers.Id = 5;
            this.bbiCallReceivers.Name = "bbiCallReceivers";
            this.bbiCallReceivers.Tag = "CallReceivers";
            this.bbiCallReceivers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonParameters_ItemClick);
            // 
            // bbiCallContanct
            // 
            resources.ApplyResources(this.bbiCallContanct, "bbiCallContanct");
            this.bbiCallContanct.Id = 6;
            this.bbiCallContanct.Name = "bbiCallContanct";
            this.bbiCallContanct.Tag = "CallContacts";
            this.bbiCallContanct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonParameters_ItemClick);
            // 
            // bbiCallTypes
            // 
            resources.ApplyResources(this.bbiCallTypes, "bbiCallTypes");
            this.bbiCallTypes.Id = 7;
            this.bbiCallTypes.Name = "bbiCallTypes";
            this.bbiCallTypes.Tag = "CallTypes";
            this.bbiCallTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonParameters_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            resources.ApplyResources(this.ribbonPageCategory1, "ribbonPageCategory1");
            // 
            // rpParameters
            // 
            this.rpParameters.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgParameters});
            this.rpParameters.Name = "rpParameters";
            resources.ApplyResources(this.rpParameters, "rpParameters");
            // 
            // rpgParameters
            // 
            this.rpgParameters.ItemLinks.Add(this.bbiCalls);
            this.rpgParameters.ItemLinks.Add(this.bbiCallReceivers);
            this.rpgParameters.ItemLinks.Add(this.bbiCallContanct);
            this.rpgParameters.ItemLinks.Add(this.bbiCallTypes);
            this.rpgParameters.Name = "rpgParameters";
            resources.ApplyResources(this.rpgParameters, "rpgParameters");
            // 
            // xtraUserControl1
            // 
            resources.ApplyResources(this.xtraUserControl1, "xtraUserControl1");
            this.xtraUserControl1.Name = "xtraUserControl1";
            // 
            // dmMainForm
            // 
            this.dmMainForm.ContainerControl = this;
            this.dmMainForm.MenuManager = this.rcMain;
            this.dmMainForm.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.dmMainForm.View = this.tabbedView1;
            this.dmMainForm.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroupProperties.ShowTabHeader = false;
            this.tabbedView1.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bvmMainForm
            // 
            this.bvmMainForm.BackstageView = this.bvcCallManagement;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.bmMainForm.SetBehaviors(this, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForForm), "C:\\Users\\Production_user22\\AppData\\Local\\CallsManagement\\settings.xml", DevExpress.Utils.Behaviors.Common.Storage.File, DevExpress.Utils.DefaultBoolean.False)))});
            this.Controls.Add(this.bvcCallManagement);
            this.Controls.Add(this.xtraUserControl1);
            this.Controls.Add(this.rcMain);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.rcMain;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bvcCallManagement)).EndInit();
            this.bvcCallManagement.ResumeLayout(false);
            this.bvccCallsManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbePalletes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeThemes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLanguages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLanguages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciThemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPallete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpParameters;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgParameters;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiCalls;
        private DevExpress.XtraBars.BarButtonItem bbiCallReceivers;
        private DevExpress.XtraBars.BarButtonItem bbiCallContanct;
        private DevExpress.XtraBars.BarButtonItem bbiCallTypes;
        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
        private DevExpress.XtraBars.Docking2010.DocumentManager dmMainForm;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.Utils.Behaviors.BehaviorManager bmMainForm;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl bvcCallManagement;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl bvccCallsManagement;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiGeneralParameters;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeLanguages;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciLanguages;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeThemes;
        private DevExpress.XtraLayout.LayoutControlItem lciThemes;
        private DevExpress.XtraEditors.SimpleButton sbApplyTheme;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cbePalletes;
        private DevExpress.XtraLayout.LayoutControlItem lciPallete;
        private DevExpress.XtraBars.Ribbon.BackstageViewManager bvmMainForm;
    }
}


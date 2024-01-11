namespace CallsManagement
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndExit = new DevExpress.XtraBars.BarButtonItem();
            this.bsiCreationDate = new DevExpress.XtraBars.BarStaticItem();
            this.bsiModifiedDate = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bsiCreationDateContent = new DevExpress.XtraBars.BarStaticItem();
            this.bsiModifiedDateContent = new DevExpress.XtraBars.BarStaticItem();
            this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
            this.rpActions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rsbEditForm = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtoeCallDate = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.meNotes = new DevExpress.XtraEditors.MemoEdit();
            this.lueCallReceiver = new DevExpress.XtraEditors.LookUpEdit();
            this.lueCallContact = new DevExpress.XtraEditors.LookUpEdit();
            this.lueCallType = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCallType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCallReceiver = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCallContact = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNotes = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCallDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.callBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxvpEditForm = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bmEditForm = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtoeCallDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCallReceiver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCallContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCallType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvpEditForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmEditForm)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndExit,
            this.bsiCreationDate,
            this.bsiModifiedDate,
            this.barButtonItem1,
            this.bsiCreationDateContent,
            this.bsiModifiedDateContent,
            this.bbiReload});
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpActions});
            this.ribbon.StatusBar = this.rsbEditForm;
            // 
            // bbiSave
            // 
            resources.ApplyResources(this.bbiSave, "bbiSave");
            this.bbiSave.Id = 1;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndExit
            // 
            resources.ApplyResources(this.bbiSaveAndExit, "bbiSaveAndExit");
            this.bbiSaveAndExit.Id = 2;
            this.bbiSaveAndExit.Name = "bbiSaveAndExit";
            this.bbiSaveAndExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndExit_ItemClick);
            // 
            // bsiCreationDate
            // 
            resources.ApplyResources(this.bsiCreationDate, "bsiCreationDate");
            this.bsiCreationDate.Id = 3;
            this.bsiCreationDate.Name = "bsiCreationDate";
            // 
            // bsiModifiedDate
            // 
            resources.ApplyResources(this.bsiModifiedDate, "bsiModifiedDate");
            this.bsiModifiedDate.Id = 4;
            this.bsiModifiedDate.Name = "bsiModifiedDate";
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bsiCreationDateContent
            // 
            this.bsiCreationDateContent.Id = 8;
            this.bsiCreationDateContent.Name = "bsiCreationDateContent";
            // 
            // bsiModifiedDateContent
            // 
            this.bsiModifiedDateContent.Id = 9;
            this.bsiModifiedDateContent.Name = "bsiModifiedDateContent";
            // 
            // bbiReload
            // 
            resources.ApplyResources(this.bbiReload, "bbiReload");
            this.bbiReload.Id = 10;
            this.bbiReload.Name = "bbiReload";
            this.bbiReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // rpActions
            // 
            this.rpActions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgActions});
            this.rpActions.Name = "rpActions";
            resources.ApplyResources(this.rpActions, "rpActions");
            // 
            // rpgActions
            // 
            this.rpgActions.ItemLinks.Add(this.bbiSave);
            this.rpgActions.ItemLinks.Add(this.bbiSaveAndExit);
            this.rpgActions.ItemLinks.Add(this.bbiReload);
            this.rpgActions.Name = "rpgActions";
            // 
            // rsbEditForm
            // 
            this.rsbEditForm.ItemLinks.Add(this.bsiCreationDate);
            this.rsbEditForm.ItemLinks.Add(this.bsiCreationDateContent);
            this.rsbEditForm.ItemLinks.Add(this.bsiModifiedDate);
            this.rsbEditForm.ItemLinks.Add(this.bsiModifiedDateContent);
            resources.ApplyResources(this.rsbEditForm, "rsbEditForm");
            this.rsbEditForm.Name = "rsbEditForm";
            this.rsbEditForm.Ribbon = this.ribbon;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtoeCallDate);
            this.layoutControl1.Controls.Add(this.dataLayoutControl1);
            this.layoutControl1.Controls.Add(this.meNotes);
            this.layoutControl1.Controls.Add(this.lueCallReceiver);
            this.layoutControl1.Controls.Add(this.lueCallContact);
            this.layoutControl1.Controls.Add(this.lueCallType);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // dtoeCallDate
            // 
            resources.ApplyResources(this.dtoeCallDate, "dtoeCallDate");
            this.dtoeCallDate.EnterMoveNextControl = true;
            this.dtoeCallDate.MenuManager = this.ribbon;
            this.dtoeCallDate.Name = "dtoeCallDate";
            this.dtoeCallDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtoeCallDate.Properties.Buttons"))))});
            this.dtoeCallDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.dtoeCallDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtoeCallDate.Properties.EditFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.dtoeCallDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtoeCallDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy hh:mm:ss tt");
            this.dtoeCallDate.StyleController = this.layoutControl1;
            // 
            // dataLayoutControl1
            // 
            resources.ApplyResources(this.dataLayoutControl1, "dataLayoutControl1");
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(706, 28);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // meNotes
            // 
            resources.ApplyResources(this.meNotes, "meNotes");
            this.meNotes.MenuManager = this.ribbon;
            this.meNotes.Name = "meNotes";
            this.meNotes.StyleController = this.layoutControl1;
            // 
            // lueCallReceiver
            // 
            resources.ApplyResources(this.lueCallReceiver, "lueCallReceiver");
            this.lueCallReceiver.MenuManager = this.ribbon;
            this.lueCallReceiver.Name = "lueCallReceiver";
            this.lueCallReceiver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lueCallReceiver.Properties.Buttons"))))});
            this.lueCallReceiver.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lueCallReceiver.Properties.Columns"), resources.GetString("lueCallReceiver.Properties.Columns1"))});
            this.lueCallReceiver.Properties.NullText = resources.GetString("lueCallReceiver.Properties.NullText");
            this.lueCallReceiver.StyleController = this.layoutControl1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxvpEditForm.SetValidationRule(this.lueCallReceiver, conditionValidationRule1);
            // 
            // lueCallContact
            // 
            resources.ApplyResources(this.lueCallContact, "lueCallContact");
            this.lueCallContact.MenuManager = this.ribbon;
            this.lueCallContact.Name = "lueCallContact";
            this.lueCallContact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lueCallContact.Properties.Buttons"))))});
            this.lueCallContact.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lueCallContact.Properties.Columns"), resources.GetString("lueCallContact.Properties.Columns1"))});
            this.lueCallContact.Properties.NullText = resources.GetString("lueCallContact.Properties.NullText");
            this.lueCallContact.StyleController = this.layoutControl1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxvpEditForm.SetValidationRule(this.lueCallContact, conditionValidationRule2);
            // 
            // lueCallType
            // 
            resources.ApplyResources(this.lueCallType, "lueCallType");
            this.lueCallType.MenuManager = this.ribbon;
            this.lueCallType.Name = "lueCallType";
            this.lueCallType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lueCallType.Properties.Buttons"))))});
            this.lueCallType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lueCallType.Properties.Columns"), resources.GetString("lueCallType.Properties.Columns1"))});
            this.lueCallType.Properties.NullText = resources.GetString("lueCallType.Properties.NullText");
            this.lueCallType.StyleController = this.layoutControl1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxvpEditForm.SetValidationRule(this.lueCallType, conditionValidationRule3);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCallType,
            this.emptySpaceItem1,
            this.lciCallReceiver,
            this.lciCallContact,
            this.lciNotes,
            this.layoutControlItem1,
            this.lciCallDate});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(730, 262);
            this.Root.TextVisible = false;
            // 
            // lciCallType
            // 
            this.lciCallType.Control = this.lueCallType;
            this.lciCallType.Location = new System.Drawing.Point(0, 48);
            this.lciCallType.Name = "lciCallType";
            this.lciCallType.Size = new System.Drawing.Size(710, 24);
            resources.ApplyResources(this.lciCallType, "lciCallType");
            this.lciCallType.TextSize = new System.Drawing.Size(66, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 180);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(710, 54);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciCallReceiver
            // 
            this.lciCallReceiver.Control = this.lueCallReceiver;
            this.lciCallReceiver.Location = new System.Drawing.Point(0, 96);
            this.lciCallReceiver.Name = "lciCallReceiver";
            this.lciCallReceiver.Size = new System.Drawing.Size(710, 24);
            resources.ApplyResources(this.lciCallReceiver, "lciCallReceiver");
            this.lciCallReceiver.TextSize = new System.Drawing.Size(66, 13);
            // 
            // lciCallContact
            // 
            this.lciCallContact.Control = this.lueCallContact;
            this.lciCallContact.Location = new System.Drawing.Point(0, 72);
            this.lciCallContact.Name = "lciCallContact";
            this.lciCallContact.Size = new System.Drawing.Size(710, 24);
            resources.ApplyResources(this.lciCallContact, "lciCallContact");
            this.lciCallContact.TextSize = new System.Drawing.Size(66, 13);
            // 
            // lciNotes
            // 
            this.lciNotes.Control = this.meNotes;
            this.lciNotes.Location = new System.Drawing.Point(0, 120);
            this.lciNotes.Name = "lciNotes";
            this.lciNotes.Size = new System.Drawing.Size(710, 60);
            resources.ApplyResources(this.lciNotes, "lciNotes");
            this.lciNotes.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 234);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(710, 32);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciCallDate
            // 
            this.lciCallDate.Control = this.dtoeCallDate;
            this.lciCallDate.Location = new System.Drawing.Point(0, 24);
            this.lciCallDate.Name = "lciCallDate";
            this.lciCallDate.Size = new System.Drawing.Size(710, 24);
            resources.ApplyResources(this.lciCallDate, "lciCallDate");
            this.lciCallDate.TextSize = new System.Drawing.Size(66, 13);
            // 
            // callBindingSource
            // 
            this.callBindingSource.DataSource = typeof(CallsManagement.Data.Call);
            // 
            // EditForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.bmEditForm.SetBehaviors(this, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForForm), "C:\\Users\\Production_user22\\AppData\\Local\\CallsManagement\\EditFormSettings.xml", DevExpress.Utils.Behaviors.Common.Storage.File, DevExpress.Utils.DefaultBoolean.False)))});
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.rsbEditForm);
            this.Controls.Add(this.ribbon);
            this.Name = "EditForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.rsbEditForm;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewForm_FormClosing);
            this.Load += new System.EventHandler(this.NewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtoeCallDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCallReceiver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCallContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCallType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvpEditForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmEditForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rsbEditForm;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit lueCallReceiver;
        private DevExpress.XtraEditors.LookUpEdit lueCallContact;
        private DevExpress.XtraEditors.LookUpEdit lueCallType;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciCallType;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciCallContact;
        private DevExpress.XtraLayout.LayoutControlItem lciCallReceiver;
        private DevExpress.XtraEditors.MemoEdit meNotes;
        private DevExpress.XtraLayout.LayoutControlItem lciNotes;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndExit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvpEditForm;
        private DevExpress.XtraBars.BarStaticItem bsiCreationDate;
        private DevExpress.XtraBars.BarStaticItem bsiModifiedDate;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtoeCallDate;
        private DevExpress.XtraLayout.LayoutControlItem lciCallDate;
        private System.Windows.Forms.BindingSource callBindingSource;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem bsiCreationDateContent;
        private DevExpress.XtraBars.BarStaticItem bsiModifiedDateContent;
        private DevExpress.XtraBars.BarButtonItem bbiReload;
        private DevExpress.Utils.Behaviors.BehaviorManager bmEditForm;
    }
}
namespace VisioUtilitiesAddIn
{
    partial class TextTools : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TextTools()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.textToolsGroup = this.Factory.CreateRibbonGroup();
            this.replaceButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.textToolsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.textToolsGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // textToolsGroup
            // 
            this.textToolsGroup.DialogLauncher = ribbonDialogLauncherImpl1;
            this.textToolsGroup.Items.Add(this.replaceButton);
            this.textToolsGroup.Label = "Text Tools";
            this.textToolsGroup.Name = "textToolsGroup";
            // 
            // replaceButton
            // 
            this.replaceButton.Label = "Replace";
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.replaceButton_Click);
            // 
            // TextTools
            // 
            this.Name = "TextTools";
            this.RibbonType = "Microsoft.Visio.Drawing";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.TextTools_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.textToolsGroup.ResumeLayout(false);
            this.textToolsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup textToolsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton replaceButton;
    }

    partial class ThisRibbonCollection
    {
        internal TextTools TextTools
        {
            get { return this.GetRibbon<TextTools>(); }
        }
    }
}

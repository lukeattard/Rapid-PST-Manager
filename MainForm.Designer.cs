using System.Windows.Forms;

namespace OSTandPSTParser
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
      this.FolderTreeView = new System.Windows.Forms.TreeView();
      this.buttonLoad = new System.Windows.Forms.Button();
      this.buttonExport = new System.Windows.Forms.Button();
      this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeSourceFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.MailTreeView = new System.Windows.Forms.TreeView();
      this.MailContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.contextMailOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
      this.MergeWorker = new System.ComponentModel.BackgroundWorker();
      this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
      this.MailStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.exportProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.MainMenuStrip.SuspendLayout();
      this.MailContextMenuStrip.SuspendLayout();
      this.MainStatusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // FolderTreeView
      // 
      this.FolderTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.FolderTreeView.CheckBoxes = true;
      this.FolderTreeView.Location = new System.Drawing.Point(12, 69);
      this.FolderTreeView.Name = "FolderTreeView";
      this.FolderTreeView.ShowNodeToolTips = true;
      this.FolderTreeView.Size = new System.Drawing.Size(461, 458);
      this.FolderTreeView.TabIndex = 0;
      this.FolderTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.rapidTreeView_AfterCheck);
      this.FolderTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.FolderTreeView_NodeMouseClick);
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(12, 27);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(341, 23);
      this.buttonLoad.TabIndex = 1;
      this.buttonLoad.Text = "Load OST/PST";
      this.buttonLoad.UseVisualStyleBackColor = true;
      this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
      // 
      // buttonExport
      // 
      this.buttonExport.Location = new System.Drawing.Point(387, 27);
      this.buttonExport.Name = "buttonExport";
      this.buttonExport.Size = new System.Drawing.Size(341, 23);
      this.buttonExport.TabIndex = 2;
      this.buttonExport.Text = "Export selected";
      this.buttonExport.UseVisualStyleBackColor = true;
      this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
      // 
      // MainMenuStrip
      // 
      this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
      this.MainMenuStrip.Name = "MainMenuStrip";
      this.MainMenuStrip.Size = new System.Drawing.Size(1293, 24);
      this.MainMenuStrip.TabIndex = 5;
      this.MainMenuStrip.Text = "MainMenuStrip";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeSourceFileToolStripMenuItem1,
            this.resetToolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // closeSourceFileToolStripMenuItem1
      // 
      this.closeSourceFileToolStripMenuItem1.Name = "closeSourceFileToolStripMenuItem1";
      this.closeSourceFileToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
      this.closeSourceFileToolStripMenuItem1.Text = "Close Source File";
      this.closeSourceFileToolStripMenuItem1.Click += new System.EventHandler(this.closeSourceFileToolStripMenuItem1_Click);
      // 
      // resetToolStripMenuItem1
      // 
      this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
      this.resetToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
      this.resetToolStripMenuItem1.Text = "Reset";
      this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem1_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem1
      // 
      this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
      this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem1.Text = "About";
      // 
      // MailTreeView
      // 
      this.MailTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.MailTreeView.CheckBoxes = true;
      this.MailTreeView.ContextMenuStrip = this.MailContextMenuStrip;
      this.MailTreeView.Location = new System.Drawing.Point(495, 69);
      this.MailTreeView.Name = "MailTreeView";
      this.MailTreeView.ShowNodeToolTips = true;
      this.MailTreeView.Size = new System.Drawing.Size(786, 458);
      this.MailTreeView.TabIndex = 6;
      // 
      // MailContextMenuStrip
      // 
      this.MailContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMailOpen,
            this.toolStripMenuItemPrint});
      this.MailContextMenuStrip.Name = "MailContextMenuStrip";
      this.MailContextMenuStrip.Size = new System.Drawing.Size(104, 48);
      // 
      // contextMailOpen
      // 
      this.contextMailOpen.Name = "contextMailOpen";
      this.contextMailOpen.Size = new System.Drawing.Size(103, 22);
      this.contextMailOpen.Text = "Open";
      // 
      // toolStripMenuItemPrint
      // 
      this.toolStripMenuItemPrint.Name = "toolStripMenuItemPrint";
      this.toolStripMenuItemPrint.Size = new System.Drawing.Size(103, 22);
      this.toolStripMenuItemPrint.Text = "Print";
      // 
      // MergeWorker
      // 
      this.MergeWorker.WorkerReportsProgress = true;
      this.MergeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MergeWorker_DoWork);
      this.MergeWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MergeWorker_ProgressChanged);
      this.MergeWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MergeWorker_RunWorkerCompleted);
      // 
      // MainStatusStrip
      // 
      this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MailStatusLabel,
            this.exportProgressBar});
      this.MainStatusStrip.Location = new System.Drawing.Point(0, 530);
      this.MainStatusStrip.Name = "MainStatusStrip";
      this.MainStatusStrip.Size = new System.Drawing.Size(1293, 22);
      this.MainStatusStrip.TabIndex = 7;
      this.MainStatusStrip.Text = "Ready";
      // 
      // MailStatusLabel
      // 
      this.MailStatusLabel.AutoSize = false;
      this.MailStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.MailStatusLabel.Name = "MailStatusLabel";
      this.MailStatusLabel.Size = new System.Drawing.Size(1039, 17);
      this.MailStatusLabel.Text = "Ready";
      this.MailStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // exportProgressBar
      // 
      this.exportProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.exportProgressBar.AutoSize = false;
      this.exportProgressBar.Name = "exportProgressBar";
      this.exportProgressBar.Size = new System.Drawing.Size(200, 16);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1293, 552);
      this.Controls.Add(this.MainStatusStrip);
      this.Controls.Add(this.MailTreeView);
      this.Controls.Add(this.MainMenuStrip);
      this.Controls.Add(this.buttonExport);
      this.Controls.Add(this.buttonLoad);
      this.Controls.Add(this.FolderTreeView);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Rapid OST and PST Manager";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.MainMenuStrip.ResumeLayout(false);
      this.MainMenuStrip.PerformLayout();
      this.MailContextMenuStrip.ResumeLayout(false);
      this.MainStatusStrip.ResumeLayout(false);
      this.MainStatusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView FolderTreeView;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonExport;
    private System.Windows.Forms.MenuStrip MainMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeSourceFileToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.TreeView MailTreeView;
    private System.Windows.Forms.ContextMenuStrip MailContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem contextMailOpen;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrint;
    internal System.ComponentModel.BackgroundWorker MergeWorker;
    private System.Windows.Forms.StatusStrip MainStatusStrip;
    private ToolStripStatusLabel MailStatusLabel;
    private ToolStripProgressBar exportProgressBar;
  }
}


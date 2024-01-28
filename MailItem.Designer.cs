using OSTandPSTParser.Properties;
using System.Resources;

namespace OSTandPSTParser
{
  partial class MailItem
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailItem));
      this.labelFrom = new System.Windows.Forms.Label();
      this.labelTo = new System.Windows.Forms.Label();
      this.textBoxFrom = new System.Windows.Forms.TextBox();
      this.mailBrowser = new System.Windows.Forms.WebBrowser();
      this.labelSubject = new System.Windows.Forms.Label();
      this.textBoxSubject = new System.Windows.Forms.TextBox();
      this.textBoxTo = new System.Windows.Forms.TextBox();
      this.mailTabs = new System.Windows.Forms.TabControl();
      this.mailTabHTML = new System.Windows.Forms.TabPage();
      this.mailTabText = new System.Windows.Forms.TabPage();
      this.mailTabHeaders = new System.Windows.Forms.TabPage();
      this.mailPlainText = new System.Windows.Forms.RichTextBox();
      this.mailHeaders = new System.Windows.Forms.RichTextBox();
      this.mailAttachements = new System.Windows.Forms.TabPage();
      this.mailAttachmentsListBox = new System.Windows.Forms.CheckedListBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.btnSaveAllAttachments = new System.Windows.Forms.Button();
      this.btnSaveCheckedAttachments = new System.Windows.Forms.Button();
      this.mailTabs.SuspendLayout();
      this.mailTabHTML.SuspendLayout();
      this.mailTabText.SuspendLayout();
      this.mailTabHeaders.SuspendLayout();
      this.mailAttachements.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // labelFrom
      // 
      this.labelFrom.AutoSize = true;
      this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelFrom.Location = new System.Drawing.Point(12, 9);
      this.labelFrom.Name = "labelFrom";
      this.labelFrom.Size = new System.Drawing.Size(60, 24);
      this.labelFrom.TabIndex = 0;
      this.labelFrom.Text = "From:";
      // 
      // labelTo
      // 
      this.labelTo.AutoSize = true;
      this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTo.Location = new System.Drawing.Point(12, 44);
      this.labelTo.Name = "labelTo";
      this.labelTo.Size = new System.Drawing.Size(38, 24);
      this.labelTo.TabIndex = 1;
      this.labelTo.Text = "To:";
      // 
      // textBoxFrom
      // 
      this.textBoxFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxFrom.Location = new System.Drawing.Point(121, 12);
      this.textBoxFrom.Name = "textBoxFrom";
      this.textBoxFrom.ReadOnly = true;
      this.textBoxFrom.Size = new System.Drawing.Size(782, 22);
      this.textBoxFrom.TabIndex = 2;
      this.textBoxFrom.WordWrap = false;
      // 
      // mailBrowser
      // 
      this.mailBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mailBrowser.Location = new System.Drawing.Point(3, 3);
      this.mailBrowser.MinimumSize = new System.Drawing.Size(20, 20);
      this.mailBrowser.Name = "mailBrowser";
      this.mailBrowser.Size = new System.Drawing.Size(997, 415);
      this.mailBrowser.TabIndex = 3;
      // 
      // labelSubject
      // 
      this.labelSubject.AutoSize = true;
      this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSubject.Location = new System.Drawing.Point(12, 77);
      this.labelSubject.Name = "labelSubject";
      this.labelSubject.Size = new System.Drawing.Size(78, 24);
      this.labelSubject.TabIndex = 4;
      this.labelSubject.Text = "Subject:";
      // 
      // textBoxSubject
      // 
      this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxSubject.Location = new System.Drawing.Point(121, 79);
      this.textBoxSubject.Name = "textBoxSubject";
      this.textBoxSubject.ReadOnly = true;
      this.textBoxSubject.Size = new System.Drawing.Size(782, 22);
      this.textBoxSubject.TabIndex = 5;
      this.textBoxSubject.WordWrap = false;
      // 
      // textBoxTo
      // 
      this.textBoxTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxTo.Location = new System.Drawing.Point(121, 46);
      this.textBoxTo.Name = "textBoxTo";
      this.textBoxTo.ReadOnly = true;
      this.textBoxTo.Size = new System.Drawing.Size(782, 22);
      this.textBoxTo.TabIndex = 6;
      this.textBoxTo.WordWrap = false;
      // 
      // mailTabs
      // 
      this.mailTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mailTabs.Controls.Add(this.mailTabHTML);
      this.mailTabs.Controls.Add(this.mailTabText);
      this.mailTabs.Controls.Add(this.mailTabHeaders);
      this.mailTabs.Controls.Add(this.mailAttachements);
      this.mailTabs.Location = new System.Drawing.Point(16, 107);
      this.mailTabs.Name = "mailTabs";
      this.mailTabs.SelectedIndex = 0;
      this.mailTabs.Size = new System.Drawing.Size(1011, 447);
      this.mailTabs.TabIndex = 7;
      // 
      // mailTabHTML
      // 
      this.mailTabHTML.Controls.Add(this.mailBrowser);
      this.mailTabHTML.Location = new System.Drawing.Point(4, 22);
      this.mailTabHTML.Name = "mailTabHTML";
      this.mailTabHTML.Padding = new System.Windows.Forms.Padding(3);
      this.mailTabHTML.Size = new System.Drawing.Size(1003, 421);
      this.mailTabHTML.TabIndex = 0;
      this.mailTabHTML.Text = "HTML";
      this.mailTabHTML.UseVisualStyleBackColor = true;
      // 
      // mailTabText
      // 
      this.mailTabText.Controls.Add(this.mailPlainText);
      this.mailTabText.Location = new System.Drawing.Point(4, 22);
      this.mailTabText.Name = "mailTabText";
      this.mailTabText.Padding = new System.Windows.Forms.Padding(3);
      this.mailTabText.Size = new System.Drawing.Size(1003, 421);
      this.mailTabText.TabIndex = 1;
      this.mailTabText.Text = "Plain Text";
      this.mailTabText.UseVisualStyleBackColor = true;
      // 
      // mailTabHeaders
      // 
      this.mailTabHeaders.Controls.Add(this.mailHeaders);
      this.mailTabHeaders.Location = new System.Drawing.Point(4, 22);
      this.mailTabHeaders.Name = "mailTabHeaders";
      this.mailTabHeaders.Padding = new System.Windows.Forms.Padding(3);
      this.mailTabHeaders.Size = new System.Drawing.Size(1003, 421);
      this.mailTabHeaders.TabIndex = 2;
      this.mailTabHeaders.Text = "Headers";
      this.mailTabHeaders.UseVisualStyleBackColor = true;
      // 
      // mailPlainText
      // 
      this.mailPlainText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mailPlainText.Location = new System.Drawing.Point(3, 3);
      this.mailPlainText.Name = "mailPlainText";
      this.mailPlainText.Size = new System.Drawing.Size(997, 415);
      this.mailPlainText.TabIndex = 0;
      this.mailPlainText.Text = "";
      // 
      // mailHeaders
      // 
      this.mailHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mailHeaders.Location = new System.Drawing.Point(3, 3);
      this.mailHeaders.Name = "mailHeaders";
      this.mailHeaders.Size = new System.Drawing.Size(997, 415);
      this.mailHeaders.TabIndex = 0;
      this.mailHeaders.Text = "";
      // 
      // mailAttachements
      // 
      this.mailAttachements.Controls.Add(this.splitContainer1);
      this.mailAttachements.Location = new System.Drawing.Point(4, 22);
      this.mailAttachements.Name = "mailAttachements";
      this.mailAttachements.Padding = new System.Windows.Forms.Padding(3);
      this.mailAttachements.Size = new System.Drawing.Size(1003, 421);
      this.mailAttachements.TabIndex = 3;
      this.mailAttachements.Text = "Attachments";
      this.mailAttachements.UseVisualStyleBackColor = true;
      // 
      // mailAttachmentsListBox
      // 
      this.mailAttachmentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mailAttachmentsListBox.FormattingEnabled = true;
      this.mailAttachmentsListBox.Location = new System.Drawing.Point(0, 0);
      this.mailAttachmentsListBox.Name = "mailAttachmentsListBox";
      this.mailAttachmentsListBox.Size = new System.Drawing.Size(618, 415);
      this.mailAttachmentsListBox.TabIndex = 0;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.mailAttachmentsListBox);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.btnSaveCheckedAttachments);
      this.splitContainer1.Panel2.Controls.Add(this.btnSaveAllAttachments);
      this.splitContainer1.Size = new System.Drawing.Size(997, 415);
      this.splitContainer1.SplitterDistance = 618;
      this.splitContainer1.TabIndex = 1;
      // 
      // btnSaveAllAttachments
      // 
      this.btnSaveAllAttachments.Location = new System.Drawing.Point(160, 30);
      this.btnSaveAllAttachments.Name = "btnSaveAllAttachments";
      this.btnSaveAllAttachments.Size = new System.Drawing.Size(98, 23);
      this.btnSaveAllAttachments.TabIndex = 0;
      this.btnSaveAllAttachments.Text = "Save All";
      this.btnSaveAllAttachments.UseVisualStyleBackColor = true;
      this.btnSaveAllAttachments.Click += new System.EventHandler(this.btnSaveAllAttachments_Click);
      // 
      // btnSaveCheckedAttachments
      // 
      this.btnSaveCheckedAttachments.Location = new System.Drawing.Point(160, 75);
      this.btnSaveCheckedAttachments.Name = "btnSaveCheckedAttachments";
      this.btnSaveCheckedAttachments.Size = new System.Drawing.Size(98, 23);
      this.btnSaveCheckedAttachments.TabIndex = 1;
      this.btnSaveCheckedAttachments.Text = "Save Checked";
      this.btnSaveCheckedAttachments.UseVisualStyleBackColor = true;
      this.btnSaveCheckedAttachments.Click += new System.EventHandler(this.btnSaveCheckedAttachments_Click);
      // 
      // MailItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1039, 567);
      this.Controls.Add(this.mailTabs);
      this.Controls.Add(this.textBoxTo);
      this.Controls.Add(this.textBoxSubject);
      this.Controls.Add(this.labelSubject);
      this.Controls.Add(this.textBoxFrom);
      this.Controls.Add(this.labelTo);
      this.Controls.Add(this.labelFrom);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MailItem";
      this.Text = "MailItem";
      this.mailTabs.ResumeLayout(false);
      this.mailTabHTML.ResumeLayout(false);
      this.mailTabText.ResumeLayout(false);
      this.mailTabHeaders.ResumeLayout(false);
      this.mailAttachements.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelFrom;
    private System.Windows.Forms.Label labelTo;
    private System.Windows.Forms.TextBox textBoxFrom;
    private System.Windows.Forms.WebBrowser mailBrowser;
    private System.Windows.Forms.Label labelSubject;
    private System.Windows.Forms.TextBox textBoxSubject;
    private System.Windows.Forms.TextBox textBoxTo;
    private System.Windows.Forms.TabControl mailTabs;
    private System.Windows.Forms.TabPage mailTabHTML;
    private System.Windows.Forms.TabPage mailTabText;
    private System.Windows.Forms.RichTextBox mailPlainText;
    private System.Windows.Forms.TabPage mailTabHeaders;
    private System.Windows.Forms.RichTextBox mailHeaders;
    private System.Windows.Forms.TabPage mailAttachements;
    private System.Windows.Forms.CheckedListBox mailAttachmentsListBox;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button btnSaveCheckedAttachments;
    private System.Windows.Forms.Button btnSaveAllAttachments;
  }
}
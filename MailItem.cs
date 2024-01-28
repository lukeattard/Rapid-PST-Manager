using Aspose.Email;
using Aspose.Email.Storage.Pst;
using OSTandPSTParser.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AEmail = Aspose.Email.Mapi;

namespace OSTandPSTParser
{
  public partial class MailItem : Form
  {
    private RapidMailItem _mailItem;
    internal MailItem(RapidMailItem mailItem)
    {
      InitializeComponent();
      _mailItem = mailItem;
      string tmpHeaders = "headers: ";
      ResourceManager RM = new global::System.Resources.ResourceManager("OSTandPSTParser.Properties.Resources", typeof(Resources).Assembly);
      this.Icon = (System.Drawing.Icon)RM.GetObject("RapidIcon");
      #region fuckoff
      //PersonalStorage pst = MainForm.Rapid.MailStore.MailStore;
      //FolderInfo folder = pst.GetFolderById(mailItem.Name.Split('|')[0]);
      //MapiMessage mapi = pst.ExtractMessage(folder.GetContents(mailItem.Index, 1)[0]);
      ////PersonalStorageQueryBuilder builder = new PersonalStorageQueryBuilder();
      //builder.MessageId.Equals(mailItem.Name); //input the message id criteria
      //MessageInfoCollection messages = folder.GetContents(builder.GetQuery());
      //MapiMessage mapi = pst.ExtractMessage(messages[0]);
      #endregion
      textBoxFrom.Text = mailItem.Message.SentRepresentingName;
      textBoxTo.Text = mailItem.Message.DisplayTo;
      textBoxSubject.Text = mailItem.Message.Subject;
      mailBrowser.DocumentText = mailItem.Message.BodyHtml;
      mailPlainText.Text = mailItem.Message.Body;

      foreach (string header in mailItem.Message.Headers)
      {
        tmpHeaders = $"{tmpHeaders}{header}:{mailItem.Message.Headers.Get(header)}\n";
      }
      mailHeaders.Text = tmpHeaders;
      foreach (AEmail.MapiAttachment tmpAttachment in mailItem.Message.Attachments)
      {
        mailAttachmentsListBox.Items.Add(tmpAttachment.LongFileName);
      }

    }

    private void btnSaveAllAttachments_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog SaveLoco = new FolderBrowserDialog();
      if (SaveLoco.ShowDialog() == DialogResult.OK)
      {
        foreach (AEmail.MapiAttachment tmpAttachment in _mailItem.Message.Attachments)
        {
            tmpAttachment.Save($"{SaveLoco.SelectedPath}\\{tmpAttachment.LongFileName}");
        }
      }
    }

    private void btnSaveCheckedAttachments_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog SaveLoco = new FolderBrowserDialog();
      List<string> checkedAttachements = new List<string>();
      if (SaveLoco.ShowDialog() == DialogResult.OK)
      {
        foreach (string currFile in mailAttachmentsListBox.CheckedItems)
        {
          checkedAttachements.Add(currFile);
        }

        foreach (AEmail.MapiAttachment tmpAttachment in _mailItem.Message.Attachments)
        {
          if (checkedAttachements.Contains(tmpAttachment.LongFileName))
          {
            tmpAttachment.Save($"{SaveLoco.SelectedPath}\\{tmpAttachment.LongFileName}");
          }
        }
      }
    }
  }
}

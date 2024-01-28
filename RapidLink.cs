using Aspose.Email.Mapi;
using OSTandPSTParser.Inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSTandPSTParser
{
  public class RapidLink
  {
    private MainForm _RapidForm;
    private String _FileName;
    private InputPST _sourcePST;
    private List<RapidMailItem> _rapidMailItems;
    private List<BackgroundWorker> _backgroundWorkers;
    public RapidLink(MainForm _MainFrom)
    {
      _RapidForm = _MainFrom;
      _rapidMailItems = new List<RapidMailItem>();
      _backgroundWorkers = new List<BackgroundWorker>();
    }

    public String FileName
    {
      get { return _FileName;  }
      set { _FileName = value; }
    }
    public MainForm RapidForm
    {
      get { return _RapidForm; }
      set { _RapidForm = value; }
    }
    internal InputPST MailStore
    {
      get { return _sourcePST; }

      set { _sourcePST = value; }
    }
    internal void AddBgWorker(BackgroundWorker worker)
    {
      _backgroundWorkers.Add(worker);
    }
    internal void AddMailItem(RapidMailItem mailItem)
    {
      _rapidMailItems.Add(mailItem);
    }
    internal bool CheckThenAddMailItem(RapidMailItem mailItem) 
    {
      if(GetMailItem(mailItem.MsgID) != null )
      {
          return false;
      }
      else
      {
        _rapidMailItems.Add(mailItem);
        return true;
      }
    }
    internal RapidMailItem GetMailItem(string msgId)
    {
      return(_rapidMailItems.Find(x => x.MsgID == msgId));
    }

  }
  internal class RapidMailItem
  {
    public RapidMailItem(string msgID, MapiMessage message, TreeNode msgTreeNode, TreeNode folderTreeNode)
    {
      this.MsgID = msgID;
      this.MsgTreeNode = msgTreeNode;
      this.FolderTreeNode = folderTreeNode;
      this.Message = message;
    }

    internal string MsgID { get; set; }
    internal TreeNode MsgTreeNode { get; set; }
    internal TreeNode FolderTreeNode  { get; set; }
    internal MapiMessage Message { get; set; }

  }
}

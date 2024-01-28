using Aspose.Email.Mapi;
using Aspose.Email.Storage.Pst;
using OSTandPSTParser.Inputs;
using OSTandPSTParser.OutputFormats;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OSTandPSTParser
{
  public partial class MainForm : Form
  {
    public static RapidLink Rapid;
    public static MainForm MainFormInstance;
    internal int nextprogress = 10;
    internal double counti = 0;
    internal double totalcount = 0;
    public MainForm()
    {
      InitializeComponent();
      MailTreeView.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(MailTreeView_DoubleClick);
      MainFormInstance = this;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      Rapid = new RapidLink(this);
    }


    private void LoadFile(String filename)
    {
      TreeNode node = FolderTreeView.Nodes.Add("ROOT", filename);
      node.Name = "ROOT";
      try
      {
        Rapid.MailStore = new InputPST(filename);

        ParseFolder(Rapid.MailStore.RootFolder, node);
        FolderTreeView.ExpandAll();
      }
      catch (Exception e)
      {
        FolderTreeView.Nodes.Remove(node);
        return;
      }
      return;
    }

    private static void ParseFolder(FolderInfo currentFolder, TreeNode node)
    {
      FolderInfoCollection folderInfoCollection = currentFolder.GetSubFolders();

      foreach (FolderInfo folderInfo in folderInfoCollection)
      {
        TreeNode snode = node.Nodes.Add($"{folderInfo.EntryIdString}|{folderInfo.DisplayName}", $"{folderInfo.DisplayName} ({folderInfo.ContentCount})");

        ParseFolder(folderInfo, snode);
      }
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
      try
      {
        OpenFileDialog dialog = new OpenFileDialog();
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          LoadFile(dialog.FileName);
          Rapid.FileName = dialog.FileName;
        }
      }
      catch (Exception ex)
      {
        return;
      }
    }

    private void buttonExport_Click(object sender, EventArgs e)
    {
      SaveFileDialog dialog = new SaveFileDialog();
      dialog.OverwritePrompt = false;
      dialog.Filter = "PST Files (*.pst)|*.pst|OST Files (*.ost)|*.OST";
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        Rapid.FileName = dialog.FileName;
        if (File.Exists(dialog.FileName))
        {
          DialogResult merge = MessageBox.Show($"Are you Sure you want to Merge selected folders with {dialog.FileName}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
          if (merge == DialogResult.No)
          {
            return;
          }
        }
        IOutputFormat outputFile = new OutputPST(dialog.FileName, Rapid.MailStore);
        MergeWorker.RunWorkerAsync(outputFile);

      }

    }

    private void rapidTreeView_AfterCheck(object sender, TreeViewEventArgs e)
    {
      if (e.Action != TreeViewAction.Unknown)
      {
        if (e.Node.Nodes.Count > 0)
          e.Node.CheckAllChildNodes(e.Node.Checked);
      }
    }

    private void closeSourceFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (FolderTreeView.SelectedNode.Name == "ROOT")
      {
        FolderTreeView.Nodes.Remove(FolderTreeView.SelectedNode);
      }
      else
      {
        closeParentNode(FolderTreeView.SelectedNode.Parent);
      }
    }

    private void resetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (TreeNode node in FolderTreeView.Nodes)
      {
        FolderTreeView.Nodes.Remove(node);
      }
    }

    private void closeParentNode(TreeNode _node)
    {
      if (_node.Name == "ROOT")
      {
        FolderTreeView.Nodes.Remove(_node);
      }
      else
      {
        closeParentNode(_node.Parent);
      }
    }

    private void closeSourceFileToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (FolderTreeView.SelectedNode.Name == "ROOT")
      {
        FolderTreeView.Nodes.Remove(FolderTreeView.SelectedNode);
      }
      else
      {
        closeParentNode(FolderTreeView.SelectedNode.Parent);
      }
    }

    private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      foreach (TreeNode node in FolderTreeView.Nodes)
      {
        FolderTreeView.Nodes.Remove(node);
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.Application.Exit();
    }

    private void MergeWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      MessageBox.Show($"{e.Result.ToString()} folders were merged into {Rapid.FileName}");
      MergeWorker.Dispose();
      exportProgressBar.Value = 0;
      MailStatusLabel.Text = "Ready";

    }
    private void MergeWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker bgWorker = sender as BackgroundWorker;
      IOutputFormat outputFile = e.Argument as IOutputFormat;
      List<TreeNode> checkedNodes = FolderTreeView.GetAllCheckedNodes();
      totalcount = checkedNodes.Count;
      counti = 0;
      try
      {
        foreach (TreeNode node in checkedNodes)
        {
          outputFile.SaveFolder(node);
          counti++;
          if((double)((counti / totalcount) * 100) > nextprogress)
          {
            MergeWorker.ReportProgress(nextprogress);
            nextprogress = nextprogress + 10;
          }
        }
        nextprogress = 10;
        e.Result = counti;
      }
      catch (Exception ex)
      {
        counti = -1;
        e.Result = ex.Message;

      }
      finally
      {
        outputFile.Close();
      }
    }

    private void FolderTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      MailTreeView.Nodes.Clear();
      TreeNode tmpTreeNode = e.Node;
      List<String> nodePath = e.Node.GetNamesPath();
      nodePath = nodePath.Skip(1).Select(n => n.Split('|')[1]).ToList();
      if (nodePath.Count < 1)
      {
        return;
      }
      TreeNode node = MailTreeView.Nodes.Add("ROOT", nodePath[nodePath.Count - 1]);

      FolderInfo folder = Rapid.MailStore.GetFolderById(tmpTreeNode.Name.Split('|')[0]);

      MessageInfoCollection messages = folder.GetContents();

      foreach (MessageInfo currMsg in folder.EnumerateMessages())
      {
        MapiMessage tmpMessage = Rapid.MailStore.ExtractMessage(currMsg);
        TreeNode tmpNode = node.Nodes.Add(currMsg.EntryIdString, $"{tmpMessage.SenderName},{tmpMessage.Subject},{tmpMessage.DeliveryTime}");
        tmpNode.Name = currMsg.EntryIdString;
        RapidMailItem tmpMailItem = new RapidMailItem(currMsg.EntryIdString, tmpMessage, tmpNode, tmpTreeNode);
        Task.Run(() => Rapid.CheckThenAddMailItem(tmpMailItem));
      }
      MailTreeView.ExpandAll();
    }

    #region todelete 
    //FolderInfo folder = sourceFile.GetSubFolder(nodePath[0]);
    //TreeNode node = MailTreeView.Nodes.Add("ROOT", nodePath[0]);
    //foreach (MapiMessage currMsg in folder.EnumerateMapiMessages())
    //{
    //  node.Nodes.Add(currMsg.ItemId, $"{currMsg.SenderName},{currMsg.Subject},{currMsg.DeliveryTime}");
    //}

    //private static void ParseFolder(FolderInfo currentFolder, TreeNode node)
    //{
    //  FolderInfoCollection folderInfoCollection = currentFolder.GetSubFolders();

    //  foreach (FolderInfo folderInfo in folderInfoCollection)
    //  {
    //    TreeNode snode = node.Nodes.Add($"{folderInfo.EntryIdString}|{folderInfo.DisplayName}", $"{folderInfo.DisplayName} ({folderInfo.ContentCount})");

    //    ParseFolder(folderInfo, snode);
    //  }
    //}

    //   List<TreeNode> selectedNodesMsgs = tmpTreeNode.Se
    //tmpTreeNode.no
    //foreach (MapiMessage currMessage in folderInfo.EnumerateMapiMessages())
    //{
    //  snode.Nodes.Add(currMessage.ItemId, currMessage.DisplayName);
    //}


    //private void LoadMailMessages_DoWork(TreeNode tmpTreeNode)
    //{

    //  List<String> nodePath = tmpTreeNode.GetNamesPath();
    //  nodePath = nodePath.Skip(1).Select(n => n.Split('|')[1]).ToList();
    //  TreeNode node = MailTreeView.Nodes.Add("ROOT", nodePath[nodePath.Count - 1]);

    //  FolderInfo folder = Rapid.MailStore.GetFolderById(tmpTreeNode.Name.Split('|')[0]);

    //  MessageInfoCollection messages = folder.GetContents();

    //  foreach (MessageInfo currMsg in folder.EnumerateMessages())
    //  {
    //    MapiMessage tmpMessage = Rapid.MailStore.ExtractMessage(currMsg);
    //    TreeNode tmpNode = node.Nodes.Add(currMsg.EntryIdString, $"{tmpMessage.SenderName},{tmpMessage.Subject},{tmpMessage.DeliveryTime}");
    //    tmpNode.Name = currMsg.EntryIdString;
    //    RapidMailItem tmpMailItem = new RapidMailItem(currMsg.EntryIdString, tmpMessage, tmpNode, tmpTreeNode);
    //    Rapid.CheckThenAddMailItem(tmpMailItem);
    //  }

    //}
    //private static void LoadMailMessages_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    //{
    //  MainFormInstance.MailTreeView.ExpandAll();
    //}
    //private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
    //{
    //  TreeNode mailNode = sender as TreeNode;
    //  string mailSearch = mailNode.Name;
    //  string[] mailProperties = mailNode.Text.Split(',');
    //  MailItem currMailItem = new MailItem(mailProperties);
    //  currMailItem.Show();
    //}
    //private void contextMailOpen_Click(object sender, EventArgs e)
    //{
    //  TreeNode mailNode = sender as TreeNode;
    //  string mailSearch = mailNode.Name;
    //  string[] mailProperties = mailNode.Text.Split(',');
    //  MailItem currMailItem = new MailItem(e.Node);
    //  currMailItem.Show();
    //}
    #endregion
    private void MailTreeView_DoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      MailItem currMailItem = new MailItem(Rapid.GetMailItem(e.Node.Name));
      currMailItem.Show();
    }
    #region wtfdelete

    // Below code wont be called because of the eventarg type, just here incase I need it. 
    //private void toolStripMenuItemOpen_Click(object sender, TreeNodeMouseClickEventArgs e)
    //{
    //  TreeNode mailNode = e.Node;
    //  string[] mailProperties = mailNode.Text.Split(',');
    //  MailItem currMailItem = new MailItem(mailProperties);
    //  currMailItem.Show();
    //}
    #endregion

    private void MergeWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      MailStatusLabel.Text = $"Currently Exporting folder {counti} of {totalcount} - {nextprogress}% Complete";
      exportProgressBar.PerformStep();
    }
  }
}

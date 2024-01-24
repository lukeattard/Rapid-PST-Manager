using Aspose.Email.Mapi;
using Aspose.Email.Storage.Pst;
using Rapid.OSTandPSTParser.Inputs;
using Rapid.OSTandPSTParser.OutputFormats;
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

namespace Rapid.OSTandPSTParser
{
  public partial class MainForm : Form
  {
    public static RapidLink Rapid;
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        Rapid = new RapidLink(this);
    }

    IInputFormat sourceFile;
    private void LoadFile(String filename)
    {
      TreeNode node = RapidTreeView.Nodes.Add("ROOT", filename);
      node.Name = "ROOT";
      try
      {
        sourceFile = new InputPST(filename);

        ParseFolder(sourceFile.RootFolder, node);
        RapidTreeView.ExpandAll();
      }
      catch (Exception e)
      {
        RapidTreeView.Nodes.Remove(node);
        return;
      }
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
        if (File.Exists(dialog.FileName))
        {
          DialogResult merge = MessageBox.Show($"Are you Sure you want to Merge selected folders with {dialog.FileName}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
          if (merge == DialogResult.No)
          {
            return;
          }
        }
        IOutputFormat outputFile = new OutputPST(dialog.FileName, sourceFile);

        List<TreeNode> selectedNodes = RapidTreeView.GetAllCheckedNodes();
        int counti = 0;
        foreach (TreeNode node in selectedNodes)
        {
          outputFile.SaveFolder(node);
          counti++;
        }

        outputFile.Close();
        MessageBox.Show($"{counti} folders were merged into {dialog.FileName}");
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
      if (RapidTreeView.SelectedNode.Name == "ROOT")
      {
        RapidTreeView.Nodes.Remove(RapidTreeView.SelectedNode);
      }
      else 
      {
        closeParentNode(RapidTreeView.SelectedNode.Parent);
      }
    }

    private void resetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (TreeNode node in RapidTreeView.Nodes)
      {
        RapidTreeView.Nodes.Remove(node);
      }
    }

    private void closeParentNode(TreeNode _node)
    {
      if (_node.Name == "ROOT")
      {
        RapidTreeView.Nodes.Remove(_node);
      }
      else
      {
        closeParentNode(_node.Parent);
      }
    }

    private void closeSourceFileToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (RapidTreeView.SelectedNode.Name == "ROOT")
      {
        RapidTreeView.Nodes.Remove(RapidTreeView.SelectedNode);
      }
      else
      {
        closeParentNode(RapidTreeView.SelectedNode.Parent);
      }
    }

    private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      foreach (TreeNode node in RapidTreeView.Nodes)
      {
        RapidTreeView.Nodes.Remove(node);
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.Application.Exit();
    }
  }
}

using Aspose.Email.Mapi;
using Aspose.Email.Storage.Pst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace OSTandPSTParser.Inputs
{
  internal class InputPST : IInputFormat
  {
    PersonalStorage sourceFile;

    internal InputPST(String filename)
    {

      try
      {    
        sourceFile = PersonalStorage.FromFile(filename);
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message, "Error");
        return;
      }
     }


    internal override FolderInfo RootFolder => sourceFile.RootFolder;

    internal override MapiMessage ExtractMessage(MessageInfo message) => sourceFile.ExtractMessage(message);

    internal override FolderInfo GetFolderById(string folderId) => sourceFile.GetFolderById(folderId);
    internal PersonalStorage MailStore { get { return sourceFile; } set { sourceFile = value; } }

  }
}

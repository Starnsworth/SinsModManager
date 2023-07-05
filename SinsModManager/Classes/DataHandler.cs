using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WinForms = System.Windows.Forms;


namespace SinsModManager.Classes
{
    

    public class PathHandler
    {
        private static string ModPath = "";
        public static PathHandler pathHandler = new PathHandler();
        
        string SetModPath(string path) //TODO: Validate that we're given a path? it's private but maybe an idea?
        {
            var mw = Application.Current.MainWindow;


            if (path != null) //If method is provided a path, will set references for mod folder path to the arg
            { 
                (mw as MainWindow).tbRebellionModsPath.Text = path;
                ModPath = path;
                return ModPath;
            }
            
            return ModPath; // If method called without arguments, will provide current path reference.
            
        }

        public void RebellionPathBuilder() //programatically find rebellion mods folder
        {
            
            string folderName = "Mods-Rebellion v1.85";
            //First place to look is Documents\My Games\Ironclad Games\Sins of a Solar Empire Rebellion
            string staticPath = "My Games\\Ironclad Games\\Sins of a Solar Empire Rebellion";
            string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string builtPath = myDocs + "\\" + staticPath;
            if (Directory.Exists(builtPath))
            {
                pathHandler.SetModPath(builtPath);
            }
            else
            {
                MessageBox.Show(builtPath + " doesnt exist. Please select the path to your " + folderName);
            }
        }

        public class UserRebellionModPath   //Usage: Create obj then run this.FolderBrowserDialog();
        {
            public string userModPath = "";
            
            public bool FolderSelectDialog()
            {
                WinForms.FolderBrowserDialog folderBrowserDialog = new WinForms.FolderBrowserDialog();
                folderBrowserDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                WinForms.DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == WinForms.DialogResult.OK)
                {
                    //If Result OK get the path that was selected and pass it to the object.
                    userModPath = folderBrowserDialog.SelectedPath;
                    return SetPathAsUserModPath(); //set the object as the definitive reference
                     
                    
                }
                else
                {
                    return false;
                }
            }
            private bool SetPathAsUserModPath()
            {
                if(userModPath != null)
                {
                    if (pathHandler.SetModPath(userModPath) == userModPath)
                    {
                        return true;
                    }
                    return false;  
                }
                return false;
            }
        }

        
    }

}

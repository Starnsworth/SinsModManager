using Gameloop.Vdf.Linq;
using Gameloop.Vdf;
using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gameloop.Vdf.JsonConverter;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SinsModManager.Classes
{

    public class vdftest
    {
        public vdftest() {
            VProperty vdf = VdfConvert.Deserialize(File.ReadAllText( "C:\\Program Files (x86)\\Steam\\steamapps\\libraryfolders.vdf"));            
            dynamic Convertedvdf = Gameloop.Vdf.JsonConverter.VTokenExtensions.ToJson( vdf );

            File.WriteAllText("libraryfolders.json", JsonConvert.SerializeObject(Convertedvdf, Formatting.Indented));
        }
    }
    public class GameEXEHandler
    {
        string steamPath; //found via registry. tells us where the libraryfolders.vdf file is. 
        string libraryFolderPath; //Found by product from steamPath.
        readonly string AppManifest = "appmanifest_204880.acf"; //filename of appmanifest_
        readonly string folderName = "Sins of a Solar Empire Rebellion";
        string completedgamepath;
        public GameEXEHandler()
        {
            //Build the features for the class
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\\Software\\Valve\\Steam"))
                {
                    if (key != null)
                    {
                        Object keyValue = key.GetValue("SteamPath");
                        if (keyValue != null)
                        {
                            steamPath = keyValue as string;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occured getting game install path. \n " + ex.Message, "Error Getting Game Path");

            }

            //open libraryfolders.vdf and find which library 204880 exists in
            //navigate to that path + foldername + executeable name
        }

        public class vdfJSONhandler
        {
            VProperty libraryFile;
            public vdfJSONhandler(string pathToVDF)
            {
                libraryFile = VdfConvert.Deserialize(File.ReadAllText(pathToVDF));
                libraryFile.ToJson().ToObject<libraryFolderModel>();
            }
            //read in the vdf and make an object

            public class libraryFolderModel
            {
                public int librayID { get; set; }

                
            }
        
        }
    }
}

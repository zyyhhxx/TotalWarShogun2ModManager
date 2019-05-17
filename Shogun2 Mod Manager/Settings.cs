using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shogun2_Mod_Manager
{
    public class Settings
    {
        public static string settingsPath = Directory.GetCurrentDirectory() + "\\settings.json";

        public string gamePath;
        public string modPath;
        public Dictionary<string, string> mods;

        public Settings()
        {
            gamePath = "";
            modPath = "";
            mods = new Dictionary<string, string>();
        }

        public Settings(string content)
        {
            JObject settingsData = JObject.Parse(content);

            // get JSON result objects into a list
            JToken gamePath = settingsData["gamePath"];
            JToken modPath = settingsData["modPath"];
            JToken mods = settingsData["mods"];

            this.gamePath = gamePath.ToObject<string>();
            this.modPath = modPath.ToObject<string>();
            this.mods = mods.ToObject<Dictionary<string, string>>();
        }

        public bool Save()
        {
            try
            {
                string output = JsonConvert.SerializeObject(this);
                File.WriteAllText(settingsPath, output);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}

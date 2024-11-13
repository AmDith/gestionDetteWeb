using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using System.IO;

namespace gestionDetteWeb.Core.Database
{
    public class Database
    {
        public static string GetActiveDatabase(string key, string key2)
        {
            try
            {
                // Charge le fichier YAML
                var yaml = new Deserializer();
                var config = LoadYamlConfig("/database.yml");

                // Accède à la valeur du fichier YAML
                if (config != null && config.ContainsKey(key))
                {
                    var subConfig = config[key] as Dictionary<string, object>;
                    if (subConfig != null && subConfig.ContainsKey(key2))
                    {
                        return subConfig[key2].ToString();
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
                return null;
            }
        }

        private static Dictionary<string, object> LoadYamlConfig(string filePath)
        {
            // Charger et désérialiser le YAML en un dictionnaire
            var yaml = new Deserializer();
            using (var reader = new StreamReader(filePath))
            {
                return yaml.Deserialize<Dictionary<string, object>>(reader);
            }
        }
    }
}
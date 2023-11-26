using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
namespace GestionGarage
{
    internal class gestiondata
    {
        private Dictionary<String, List<Dictionary<String, String>>> data;
        private string nameFile = "data.json";
        public gestiondata() {
            if (!File.Exists(nameFile))
            {
                data = new Dictionary<string, List<Dictionary<string, string>>>();
                data.Add("moteur", new List<Dictionary<string, string>> ());
                data.Add("vehicule", new List<Dictionary<string, string>>());
                CreateJsonFile(data);
            }
            else
            {
                data = LoadDataFromJsonFile();
            }
        }
        private Dictionary<String, List<Dictionary<String, String>>> LoadDataFromJsonFile()
        {
            try
            {
                string fileContent = File.ReadAllText(nameFile);
                Dictionary<String, List<Dictionary<String, String>>> loadedData =
                    JsonConvert.DeserializeObject<Dictionary<String, List<Dictionary<String, String>>>>(fileContent);

                return loadedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la lecture du fichier : {ex.Message}");
                return null;
            }
        }
        private void CreateJsonFile(Dictionary<String,List<Dictionary<String,String>>> data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(nameFile, jsonData);
        }
        public Dictionary<String,List<Dictionary<String,String>>> getdata() {
            return data;
        }
        public List<Dictionary<String,String>> getVehicule()
        {
            return data["vehicule"];
        }
        public List<Dictionary<String, String>> getmoteur()
        {
            return data["moteur"];
        }
    }
}

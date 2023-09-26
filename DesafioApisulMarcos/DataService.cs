using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DesafioApisulMarcos
{
    public class DataService
    {
        public static List<ElevadorModel> LerDadosExternos(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                List<ElevadorModel> dadosExternos = JsonConvert.DeserializeObject<List<ElevadorModel>>(jsonData);
                return dadosExternos;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao ler dados externos: {e.Message}");
                return new List<ElevadorModel>();
            }
        }

        // Outros métodos da classe DataService
    }
}

using System;
using System.Collections.Generic;
using System.IO;
//using System.Text.Json;
using Newtonsoft.Json;


namespace DesafioApisulMarcos
{
    public class Entradas
    {
        private string Path { get; set; }

        public List<ElevadorModel> RecebeEntradas()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;

            if (!string.IsNullOrEmpty(parentDirectory))
            {
                parentDirectory = parentDirectory.Replace("\\bin\\Debug", "\\dados");
                this.Path = System.IO.Path.Combine(parentDirectory, "input.json");
            }

            List<ElevadorModel> inputs = new List<ElevadorModel>();

            try
            {
                // Ler o conteúdo do arquivo JSON
                string jsonString = File.ReadAllText(Path);

                // Desserializar o JSON em uma lista de ElevadorModel
                //inputs = JsonSerializer.Deserialize<List<ElevadorModel>>(jsonString);
                inputs = JsonConvert.DeserializeObject<List<ElevadorModel>>(jsonString);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo JSON de entrada não encontrado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo JSON: {ex.Message}");
            }

            return inputs;
        }
    }
}

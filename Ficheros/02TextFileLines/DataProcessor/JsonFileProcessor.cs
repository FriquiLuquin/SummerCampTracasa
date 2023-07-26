using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataProcessor
{
    public class JsonFileProcessor : IFileProcessor
    {
        public string InputFilePath { get; }
        public string OutputFilePath { get; }

        public JsonFileProcessor(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        public void Process()
        {
            // Using read all text
            string originalText = File.ReadAllText(InputFilePath);

            // TODO: Procesar los ficheros JSON

            List<Moneda> listaMonedas = JsonConvert.DeserializeObject<List<Moneda>>(originalText);

            foreach(Moneda m in listaMonedas)
            {
                Console.WriteLine($"{m.nombre}, {m.codigo}, {m.valorEnDolares}");
                m.nombre = m.nombre.ToUpperInvariant();
            }

            string processedText = JsonConvert.SerializeObject(listaMonedas);
            // string[] lines = processedText.Split(new char[] {'' });
            File.WriteAllText(OutputFilePath, processedText);
        }
    }
}
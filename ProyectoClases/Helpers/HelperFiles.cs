using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        // Necesitamos dos metodos: read y write.
        // Los metodos deben ser asincronos.
        // En los metodos de clase no grafica, debemos utilizar la clase Task para metodos asincronos. No se utiliza void.
        // 1) Si es un void, se utiliza Task
        // 2) Si es un return, utilizamos Task<Clase>
        public async Task WriteFileAsync(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }
    }
}
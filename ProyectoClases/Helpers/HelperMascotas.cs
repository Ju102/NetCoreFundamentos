using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        private HelperFiles helper;
        private string path;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascotas.txt";
        }

        private void ConvertirMascotasList(string data)
        {
            // Garfield,Gato@Pluto, Perro
            this.Mascotas.Clear();
            string[] datosMascota = data.Split('@');
            foreach(string datos in datosMascota)
            {
                string[] propiedades = datos.Split(',');
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
            }
        }

        private string ConvertirMascotasString()
        {
            string data = "";

            foreach (Mascota mascota in this.Mascotas)
            {
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                data += propiedades + "@";
                data.TrimEnd('@');
            }
            return data;
        }

        public async Task<string> ReadMascotasAsync()
        {
            string content = await this.helper.ReadFileAsync(this.path);
            return content;
        }

        public async Task WriteMascotasAsync(string content)
        {
            await this.helper.WriteFileAsync(this.path, content);
        }

        // Que el programador escriba write y guardamos las mascotas.
        // Que el programador escriba read y leamos un string para llenar la coleccion.

    }
}

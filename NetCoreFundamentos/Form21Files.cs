using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            // Cuando hablamos de rutas o caracteres especiales, tenemos dos formas de escribirlos
            // 1. C:\carpeta\1.txt => this.Path = "C:\\carpeta\\1.txt"; para evitar que se tome \ como de escape
            // 2. Utilizar @ antes del string => this.Path = @"C:\carpeta\1.txt";
            this.Path = "file1.txt";
            this.helper = new HelperFiles();
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.Lista.Items.Add(this.txtNuevoNombre.Text);
            this.txtNuevoNombre.Text = "";
            this.txtNuevoNombre.Focus();
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            //FileInfo file = new FileInfo(this.Path);
            //using (TextReader reader = file.OpenText())
            //{
            //    string content = await reader.ReadToEndAsync();
            //    reader.Close();
            //    this.txtContenidoFile.Text = content;
            //}
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenidoFile.Text = content;
            string[] nombres = content.Split(',');
            this.Lista.Items.Clear();
            foreach (var nombre in nombres) {
                this.Lista.Items.Add(nombre);
            }
            
        }

        private async void btnEscribirFile_Click(object sender, EventArgs e)
        {
            /*
            // Tenemos una clase llamada FileInfo que nos devuelve un file para generar un writer/reader
            FileInfo file = new FileInfo(this.Path);
            // Creamos el fichero
            using (TextWriter writer = file.CreateText())
            {
                string content = this.GetNombresListbox();
                await writer.WriteAsync(content);
                // Despues de escribir en cualquier fichero, debemos liberar la memoria para hacerlo fijo
                await writer.FlushAsync();
                writer.Close();
                MessageBox.Show("Fichero guardado con éxito", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            */

            string content = this.GetNombresListbox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Fichero guardado con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GetNombresListbox()
        {
            string data = "";
            foreach(string name in this.Lista.Items)
            {
                data += name + ",";
                
            }
            data = data.Trim(',');
            return data;
        }

    }
}

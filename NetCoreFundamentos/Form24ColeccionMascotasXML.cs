using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form24ColeccionMascotasXML : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotasList;

        public Form24ColeccionMascotasXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(ColeccionMascotas));
            this.mascotasList = new ColeccionMascotas();

        }

        private void btnAddMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            this.mascotasList.Add(mascota);
            this.DibujarMascotas();

            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
        }

        private void btnReadMascotas_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("listamascotas.xml"))
            {
                this.mascotasList = (ColeccionMascotas)this.serializer.Deserialize(reader);
                reader.Close();
                this.DibujarMascotas();
            }
        }

        private async void btnSaveMascotas_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("listamascotas.xml"))
            {
                this.serializer.Serialize(writer, this.mascotasList);
                await writer.FlushAsync();
                writer.Close();
                this.Mascotas.Items.Clear();
                this.mascotasList.Clear();
            }
        }

        private void DibujarMascotas()
        {
            this.Mascotas.Items.Clear();
            foreach (Mascota mas in this.mascotasList)
            {
                this.Mascotas.Items.Add(mas.Nombre);
            }
        }

        private void Mascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.Mascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.mascotasList[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            // Abrir el openFile para seleccionar la imagen
            this.openFileDialog1.ShowDialog();
            // Recuperamos la ruta de la imagen
            string path = this.openFileDialog1.FileName;
            // Dibujamos la imagen en el form
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}

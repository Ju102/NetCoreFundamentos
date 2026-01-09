using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;

        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeerClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascotas.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtEdad.Text = mascota.Edad.ToString();

            this.GetImagenString(mascota.Imagen);
        }

        private async void btnGuardarClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            mascota.Imagen = GetStringImagen();
            // Las clases que se utilizan son de tipo Stream:
            // - para escribir necesitamos la clase StreamWriter
            // - para leer necesitamos la clase StreamReader
            using (StreamWriter writer = new StreamWriter("mascotas.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
            

            MessageBox.Show("Datos guardados con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private string GetStringImagen()
        {
            Image imagen = this.pictureBox1.Image;
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Image));
            string image = Convert.ToBase64String((byte[])converter.ConvertTo(imagen, typeof(byte[])));
            return image;


        }

        private void GetImagenString(string image)
        {
            byte[] imagen = Convert.FromBase64String(image);
            MemoryStream memory = new MemoryStream(imagen);
            this.pictureBox1.Image = Image.FromStream(memory);
        }
    }
}

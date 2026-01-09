using ProyectoClases.Helpers;
using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form22MascotasFiles : Form
    {
        HelperMascotas helper;

        public Form22MascotasFiles()
        {
            InitializeComponent();
            helper = new HelperMascotas();
        }

        private void btnAddMascota_Click(object sender, EventArgs e)
        {

        }

        private async void btnReadFileMascotas_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            
        }

        private async void btnWriteLista_Click(object sender, EventArgs e)
        {
        }

        public void MostrarMascotas()
        {
            this.Mascotas.Items.Clear();
            foreach(Mascota mascota in this.helper.Mascotas)
            {
                this.Mascotas.Items.Add(mascota.Nombre);
            }
        }
    }
}

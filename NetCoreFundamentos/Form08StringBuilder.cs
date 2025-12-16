using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {

            Stopwatch crono = new Stopwatch();
            string texto = this.txtTexto.Text;
            int longitud = texto.Length;
            crono.Start();

            string aux = "";

            /*
            for(int i = 0;i < longitud; i++)
            {
                char letra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }
            */

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                aux += texto[i];
            }

            crono.Stop();

            // El objeto Stopwatch contiene una serie de propiedades para comprobar el tiempo que dura el proceso.
            this.lblTiempo.Text = "Tiempo: " + crono.Elapsed.Seconds + "s " + crono.Elapsed.Milliseconds + "ms.";
            this.txtResultado.Text = aux;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch crono = new Stopwatch();
            StringBuilder texto = new StringBuilder();
            texto.Append(this.txtTexto.Text);
            int longitud = texto.Length;
            crono.Start();

            string aux = "";

            /*
            for(int i = 0;i < longitud; i++)
            {
                char letra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }
            */

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                aux += texto[i];
            }

            crono.Stop();

            // El objeto Stopwatch contiene una serie de propiedades para comprobar el tiempo que dura el proceso.
            this.lblTiempo.Text = "Tiempo: " + crono.Elapsed.Seconds + "s " + crono.Elapsed.Milliseconds + "ms.";
            this.txtResultado.Text = aux;
        }
    }
}

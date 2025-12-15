using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {

        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;
            string textoNumeros = this.txtNumeros.Text;
            for(int i = 0; i< textoNumeros.Length;i++)
            {
                char caracter = textoNumeros[i];
                if (Char.IsNumber(caracter))
                {
                    // int numero = int.Parse(caracter.ToString());
                    int numero = Convert.ToInt32(caracter.ToString());
                    suma += numero;
                }
            }
            this.lblResultado.Text = "Resultado: " + suma;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09ISBN : Form
    {
        public Form09ISBN()
        {
            InitializeComponent();
        }

        private void btnISBN_Click(object sender, EventArgs e)
        {
            string isbn = this.txtISBN.Text;
            if (isbn.Length != 10)
            {
                MessageBox.Show("El ISBN debe tener diez numeros.","Error de validación",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    suma += int.Parse(isbn[i].ToString()) * (i + 1);
                }
                int resultado = suma % 11;
                if (resultado != 0)
                {
                    this.lblResultado.ForeColor = Color.Red;
                    this.lblResultado.Text = "ISBN incorrecto";
                }
                else
                {
                    this.lblResultado.ForeColor = Color.Green;
                    this.lblResultado.Text = "ISBN correcto";
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
            this.txtNumero1.TextAlign = HorizontalAlignment.Center;
            this.txtNumero2.TextAlign = HorizontalAlignment.Center;

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtNumero1.Text);
            int num2 = int.Parse(this.txtNumero2.Text);

            int resultado = num1 + num2;
            this.txtResultado.TextAlign = HorizontalAlignment.Center;
            this.txtResultado.Text = resultado.ToString();
        }
    }
}

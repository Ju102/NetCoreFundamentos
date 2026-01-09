using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> cajas;

        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.cajas = new List<CheckBox>();
            foreach (CheckBox caja in this.panel1.Controls)
            {
                caja.Enabled = false;
                this.cajas.Add(caja);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            Random rand = new Random();

            foreach(CheckBox caja in cajas)
            {
                caja.Enabled = true;
                caja.Checked = false;
                caja.Text = "0";
                int num = rand.Next(1, 50);
                caja.Text = num.ToString();
                caja.CheckStateChanged += sumarRestarValor;
            }
        }

        private void sumarRestarValor(object? sender, EventArgs e)
        {
            CheckBox caja = (CheckBox)sender;
            int suma = int.Parse(this.txtSuma.Text);
            int valor = int.Parse(caja.Text);
            if (caja.Checked)
            {
                suma += valor;
            } else
            {
                suma -= valor;
            }

            this.txtSuma.Text = suma.ToString();
        }
    }
}

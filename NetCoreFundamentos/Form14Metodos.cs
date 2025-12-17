using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        void GetDobleValor(int numero)
        {
            numero = numero * 2;
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        int GetDoble(int numero)
        {
            return numero * 2;
        }

        // num y numero solo comparten valor, pero no referencia, no ocupan el mismo espacio de memoria.
        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(num);
            this.txtResultado.Text = num.ToString();
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDobleReferencia(ref num);
            this.txtResultado.Text = num.ToString();
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {

        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Tenemos una enumeración llamada Keys que nos permite acceder a
            // los codigos del teclado. Para ello debemos conocer el codigo ASCII de la tecla.
            // UTIL: Para asegurar funcionalidad en distintos OS, se utiliza la enumeración Keys
            char teclaBorrar = (char)Keys.Back;

            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                // Indica si nos hacemos cargo del evento de Key
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                // Indica si nos hacemos cargo del evento de Key
                e.Handled = true;
            }
        }
    }
}

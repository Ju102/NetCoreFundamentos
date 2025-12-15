using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;

            // Comprobar que no el email no tenga ninguna @ ni al principio ni al final
            email = email.Trim('@');
            this.txtEmail.Text = email;

            // Comprobar que el email tenga una unica @
            int contador = 0;
            for (int i = 0;i<email.Length;i++)
            {
                if (email.ElementAt(i) == '@')
                {
                    contador++;
                }
            }
            if (contador != 1)
            {
                this.txtEmail.BackColor = Color.Red;
                MessageBox.Show("El correo debe contener una @", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int posPunto = email.LastIndexOf('.');
                int posArroba = email.IndexOf('@');
                if (posPunto == -1)
                {
                    this.txtEmail.BackColor = Color.Red;
                    MessageBox.Show("El correo debe contener al menos un punto", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (posArroba > posPunto)
                {
                    this.txtEmail.BackColor = Color.Red;
                    MessageBox.Show("Debe haber un punto después de la @", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string dominio = email.Substring(posPunto + 1);
                    if (dominio.Length < 2 || dominio.Length > 3)
                    {
                        this.txtEmail.BackColor = Color.LightSalmon;
                        MessageBox.Show("El dominio debe tener de dos a tres caracteres", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.txtEmail.BackColor = Color.LightGreen;
                        this.lblResultado.Text = "El email tiene el formato correcto.";
                    }
                }
            }

        }
    }
}

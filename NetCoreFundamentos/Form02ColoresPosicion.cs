using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtPosicionX.Text);
            int y = int.Parse(this.txtPosicionY.Text);

            this.lblTestPosicion.Location = new Point(x,y);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int red = int.Parse(this.txtRed.Text);
            int green = int.Parse(this.txtGreen.Text);
            int blue = int.Parse(this.txtBlue.Text);

            if (red < 0 || red > 255)
            {
                MessageBox.Show("El rango de color rojo debe estar entre 0 y 255","Fuera de rango",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } else if (blue < 0 || blue > 255) {
                MessageBox.Show("El rango de color azul debe estar entre 0 y 255", "Fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (green < 0 || green > 255) {
                MessageBox.Show("El rango de color verde debe estar entre 0 y 255", "Fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                this.BackColor = Color.FromArgb(255, red, green, blue);
            }
        }
    }
}
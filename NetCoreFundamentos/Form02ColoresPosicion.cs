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

            BackColor = Color.FromArgb(255, red, green, blue);
        }
    }
}

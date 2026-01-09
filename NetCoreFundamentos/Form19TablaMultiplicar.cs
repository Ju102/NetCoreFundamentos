using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones;
        public Form19TablaMultiplicar()
        {  
            InitializeComponent();
            List<Button> botones = new List<Button>();
        }

        private void hacerTabla(object? sender, EventArgs e)
        {
            int factor = int.Parse(((Button)sender).Text);
            int contador = 0;

            foreach (Control ctrl in this.groupBox1.Controls)
            {

                if (ctrl is TextBox)
                {
                    contador += 1;
                    ((TextBox)ctrl).Text = (contador * factor).ToString();

                }
            }
        }
    }
}

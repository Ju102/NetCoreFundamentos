using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToShortDateString();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);

            if (this.rdbDias.Checked)
            {
                fecha = fecha.AddDays(incremento);
            } else if (this.rdbMeses.Checked)
            {
                fecha = fecha.AddMonths(incremento);
            } else
            {
                fecha = fecha.AddYears(incremento);
            }

                this.txtFechaFinal.Text = fecha.ToShortDateString(); 
        }

        private void chkFormatoFecha_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chkFormatoFecha.Checked)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }
    }
}
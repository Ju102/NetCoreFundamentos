using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtElemento.Text;
            this.lstElementos.Items.Add(elemento);
            this.txtElemento.Focus();
            this.txtElemento.Text = "";
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";

            for (int i = 0; i < this.lstElementos.SelectedItems.Count; i++)
            {
                object cosa = this.lstElementos.SelectedItems[i];
                string texto = cosa.ToString();
            }

            //Una ventaja del foreach es que podemos recorrer y hacer casting de los objetos, a la vez.
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ", ";
            }

            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }
            this.lblIndex.Text += indices.Trim(',');
            this.lblItem.Text += items.Trim(',');
        }


        private void btnEliminarTodo_Click_1(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
            this.txtElemento.Text = "";
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            for (int i = this.lstElementos.SelectedItems.Count - 1; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.Tienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;

            int index = this.Tienda.Items.IndexOf(producto);

            if (index == -1)
            {
                this.Tienda.Items.Add(producto);
            }
            else
            {
                this.Tienda.SelectedItem = this.Tienda.Items[index];
            }

            this.txtProducto.Text = "";
            this.txtProducto.Focus();

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int longitud = this.Tienda.SelectedItems.Count;

            for (int i = longitud - 1; i >= 0; i--)
            {
                int index = this.Tienda.SelectedIndices[i];
                this.Tienda.Items.RemoveAt(index);
            }

            this.txtProducto.Text = "";
            this.txtProducto.Focus();
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            this.Tienda.Items.Clear();

            this.txtProducto.Text = "";
            this.txtProducto.Focus();
        }

        private void btnEnviarTienda_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.Tienda.SelectedItems)
            {
                this.Almacen.Items.Add(obj);
            }

            int longitud = this.Tienda.SelectedItems.Count;

            for (int i = longitud - 1; i >= 0; i--)
            {
                int index = this.Tienda.SelectedIndices[i];
                this.Tienda.Items.RemoveAt(index);
            }

        }

        private void btnEnviarTiendaTodos_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.Tienda.Items)
            {
                this.Almacen.Items.Add(obj);
            }

            this.Tienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int pos = this.Almacen.SelectedIndex;
            if (pos != 0)
            {
                pos--;
                this.Almacen.SelectedIndex = pos;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {

        }
    }
}

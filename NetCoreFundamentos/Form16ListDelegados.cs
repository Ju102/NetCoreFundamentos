using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;

        public Form16ListDelegados()
        {
            InitializeComponent();
            contador = 0;
            // Almacenamos todos los botones en una nueva coleccion
            List<Button> botones = new List<Button>();

            /*
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones.Add(this.button4);
            botones.Add(this.button5);
            botones.Add(this.button6);
            */
            // Añadimos dinámicamente todos los botones del formulario
            foreach(Control control in this.Controls)
            {
                if (control is Button)
                botones.Add((Button)control);
            }


            // Creamos un metodo para que todos los botones lean al ser pulsados
            foreach(Button boton in botones)
            {
                boton.Click += PulsarBoton;
            }

        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador += 1;

            // Acceder al objeto que realiza la peticion al metodo mediante sender
            ((Button)sender).BackColor = Color.Orange;

            this.txtContador.Text = contador.ToString();
        }
    }
}

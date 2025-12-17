using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();

            List<Button> tonobes = new List<Button>();
            // Detecta automaticamente los elementos
            tonobes.Add(this.button1);
            tonobes.Add(this.button2);
            tonobes.Add(this.button3);
            // tonobes.Add(this.textBox1); => detecta el tipado y da error de compilacion. Para evitarlo, cambiar tipado a Control, en este caso.

            tonobes[0].Text = "Botón 1"; // sin necesidad de hacer casting



            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);

            // Si deseamos acceder a un objeto y modificar alguna característica necesitamos realizar un casting
            // coleccion[0].BackColor = Color.Yellow; => se debe realizar un casting
            ((Button)coleccion[0]).BackColor = Color.Red;

            foreach(Button boton in coleccion)
            {
                boton.BackColor = Color.LightGreen;
            }

            // ¿Y si agregamos otro control que no sea un button?
            coleccion.Add(this.textBox1);

            // foreach (Button boton in coleccion) {} compila pero da error al ejecutar
            
            foreach(Control obj in coleccion)
            {
                obj.BackColor = Color.Blue;
                // Cuando tenemos multiples objetos de diferentes clases, nos podemos abstraer en el recorrido,
                // pero a lo mejor necesitamos alguna caracteristica especial de cada uno.
                // Por ejemplo, un Textbox tiene un método Paste() que la clase Control no tiene.
                if (obj is TextBox) // NOTA: el metodo ToString() pertenece a la clase Object
                {
                    ((TextBox)obj).Paste();
                }
            }

            this.button1.Click += MetodoDelegado;

        }
        void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
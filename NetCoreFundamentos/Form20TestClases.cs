using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Andrés";
            persona.Apellidos = "Iniesta";
            persona.Edad = 50;
            persona.Genero = TipoGenero.Masculino;
            persona.Nacionalidad = Paises.España;
            /*
            persona.Domicilio.Calle = "Ave del Paraiso";
            persona.Domicilio.Calle = "Ave del Paraiso";
            persona.Domicilio.Calle = "Ave del Paraiso";
            */
            this.Lista.Items.Add(persona.GetNombreCompleto() + " (" + persona.Edad + " años). Género " + persona.Genero
                + ". Nacionalidad: " + persona.Nacionalidad);
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {

            // Sin constructor en la clase Empleado, usa el constructor padre de Persona
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Muy Atareado";
            this.Lista.Items.Add("Empleado: " + emp.GetNombreCompleto() +
            ". Salario: " + emp.GetSalarioMinimo() + " EUR. Días Vacaciones: " + emp.GetVacaciones());

            // Con constructor, el padre no se sustituye, siempre se leera el constructor base, aunque esté vacío y el constructor hijo si tenga parametros
            // Empleado emp2 = new Empleado("Nombre", "Apellidos");

            Director dire = new Director();
            dire.Nombre = "Director";
            dire.Apellidos = "Mafioso";
            this.Lista.Items.Add("Director: " + dire.GetNombreCompleto() + ". Salario: " + dire.GetSalarioMinimo() + " EUR. Días Vacaciones: " + dire.GetVacaciones());
        }
    }
}

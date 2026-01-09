using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        internal int SalarioMinimo { get; set; }

        public Empleado() // : base("Apellido", "Apellido") para llamar explicitamente a uno de los constructores del padre
        {
            Debug.WriteLine("Constructor de Empleado vacío");
            this.SalarioMinimo = 1600;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetVacaciones()
        {
            Debug.WriteLine("GetVacaciones() de Empleado");
            return 22;
        }

        public Empleado(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor de Empleado con dos parametros");
        }
    }
}

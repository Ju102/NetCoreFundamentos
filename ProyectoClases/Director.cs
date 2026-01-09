using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor Director");
            this.SalarioMinimo += 200;
        }

        public override int GetVacaciones()
        {
            int vacacionesEmpleado = base.GetVacaciones();
            Debug.WriteLine("GetVacaciones() Director");
            return vacacionesEmpleado + 8;
        }
    }
}

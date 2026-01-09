using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public interface IFactura
    {
        // Una interface solo tiene estructura de declaracion de elementos
        int PrecioBase { get; set; }
        int PrecioTotal { get; set; }

        void calcularIVA();

        void odioHacienda(int mucho);
    }
}

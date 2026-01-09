using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino = 0, Femenino = 1 }
    public enum Paises { España, UE, Reino_Unido, EE_UU }

    public class Persona
    {
        public Persona()
        {
            Debug.WriteLine("Constructor de Persona vacío");
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor de Persona con dos parametros");
        }

        #region Propiedades

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                Random rand = new Random();
                int dato = rand.Next(1, 20);
                this._DescripcionThis = "Descripcion: " + dato;
            }
        }
        // Propiedades autoimplementadas
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }


        public TipoGenero Genero {
            get { return this._Genero; }
            set {
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("El valor excede el rango");
                } else
                {
                    this._Genero = value;
                }
            }
        }

        public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set
            {
                if (value != Paises.España && value != Paises.UE &&
                    value != Paises.Reino_Unido && value != Paises.EE_UU)
                {
                    throw new Exception("El valor excede el rango");
                }
                else
                {
                    this._Nacionalidad = value;
                }
            }
        }

        // Campos de propiedad
        private TipoGenero _Genero;
        private Paises _Nacionalidad;
        private int _Edad;

        // Propiedades extendidas
        public int Edad {
            // Devolvemos el valor
            get { return this._Edad; }

            // Establecemos el valor
            // PROGRAMADOR: persona.Edad = -25
            set {

                if (value < 0)
                {
                    // El error es grave: lanzamos una excepcion
                    throw new Exception("La edad no puede ser negativa");

                    // Lo solucionamos en silencio: this.Edad = 0;
                } else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion

        #region Metodos
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(int n1)
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(int n1, int n2)
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(string tipo)
        {
            return this.Nombre + " " + this.Apellidos;
        }
        #endregion
    }
}

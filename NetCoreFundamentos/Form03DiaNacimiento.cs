using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnFechaNacimiento_Click(object sender, EventArgs e)
        {
            string nombreDia = "";
            DateTime fecha = DateTime.Today;

            // Incorrecto: fecha.isLeapYear()
            int anyo = fecha.Year;

            if (this.txtDiaNacimiento.Text == "" ||
                this.txtMesNacimiento.Text == "" ||
                this.txtYearNacimiento.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int dia = int.Parse(this.txtDiaNacimiento.Text);
                int mes = int.Parse(this.txtMesNacimiento.Text);
                int year = int.Parse(this.txtYearNacimiento.Text);
                bool bisiesto = ((year%4 == 0 && year%100!=0) || year%400==0);
                int maximoFebrero = 28;
                if (bisiesto)
                {
                    maximoFebrero = 29;
                }

                if (year <= 0)
                {
                    MessageBox.Show("El año debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (mes < 1 || mes > 12)
                {
                    MessageBox.Show("El mes debe estar entre 1 y 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((dia < 1 || dia > 31) || (mes == 2 && dia > maximoFebrero))
                {
                    MessageBox.Show("El dia debe estar entre 1 y 31(28/29 en febrero)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    // Ajustes de mes y año
                    if (mes == 1)
                    {
                        mes = 13;
                        year -= 1;
                    }
                    else if (mes == 2)
                    {
                        mes = 14;
                        year -= 1;
                    }

                    // Calculo de sumandos
                    int oper1 = ((mes + 1) * 3) / 5;
                    int oper2 = year / 4;
                    int oper3 = year / 100;
                    int oper4 = year / 400;

                    // Calculo de resultado
                    int resultado = dia + 2 * mes + year + oper1 + oper2 - oper3 + oper4 + 2;
                    int resultado2 = resultado / 7;

                    // Calculo de dia
                    int diaSemana = resultado - (resultado2 * 7);

                    switch (diaSemana)
                    {
                        case 0:
                            nombreDia = "Sábado";
                            break;
                        case 1:
                            nombreDia = "Domingo";
                            break;
                        case 2:
                            nombreDia = "Lunes";
                            break;
                        case 3:
                            nombreDia = "Martes";
                            break;
                        case 4:
                            nombreDia = "Miércoles";
                            break;
                        case 5:
                            nombreDia = "Jueves";
                            break;
                        case 6:
                            nombreDia = "Viernes";
                            break;
                    }

                    lblDiaSemana.Text = "El dia de la semana es " + nombreDia;
                }
            }
        }
    }
}
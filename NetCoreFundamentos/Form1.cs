namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            // Solo escribimos aquí
            this.txtNombre.Location = new Point(50,50);
            this.txtNombre.Text = "Soy un texto nuevo";
            this.txtNombre.Width = 100;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.txtNombre.BackColor = Color.Peru;

            // CONVERSION AUTOMATICA
            int mayor = 80;
            /* short menor = mayor; => No funciona de int a short*/

            short peque = 2;
            mayor = peque; // Sí se puede de short a int

            // CONVERSION STRING A PRIMITIVO
            string texto = "427";
            int numero = int.Parse(texto); // si se le envia un numero decimal, no es capaz de redondearlo.
            double doble = double.Parse(texto);

            // CONVERSION ENTRE PRIMITIVOS
            int mayor2 = 80;
            short menor = (short) mayor2;

            // CONVERSION OBJETO A STRING
            string text = mayor2.ToString();

        }
    }
}

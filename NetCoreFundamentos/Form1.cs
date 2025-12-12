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
        }
    }
}

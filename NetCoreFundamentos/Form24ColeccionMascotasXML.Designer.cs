namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblRaza = new Label();
            txtRaza = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            btnAddMascota = new Button();
            Mascotas = new ListBox();
            btnReadMascotas = new Button();
            btnSaveMascotas = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(38, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(38, 65);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(31, 15);
            lblRaza.TabIndex = 2;
            lblRaza.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(95, 62);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(38, 94);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(95, 91);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // btnAddMascota
            // 
            btnAddMascota.Location = new Point(69, 130);
            btnAddMascota.Name = "btnAddMascota";
            btnAddMascota.Size = new Size(98, 29);
            btnAddMascota.TabIndex = 6;
            btnAddMascota.Text = "Nueva Mascota";
            btnAddMascota.UseVisualStyleBackColor = true;
            btnAddMascota.Click += btnAddMascota_Click;
            // 
            // Mascotas
            // 
            Mascotas.FormattingEnabled = true;
            Mascotas.Location = new Point(242, 14);
            Mascotas.Name = "Mascotas";
            Mascotas.Size = new Size(151, 184);
            Mascotas.TabIndex = 7;
            Mascotas.SelectedIndexChanged += Mascotas_SelectedIndexChanged;
            // 
            // btnReadMascotas
            // 
            btnReadMascotas.Location = new Point(259, 204);
            btnReadMascotas.Name = "btnReadMascotas";
            btnReadMascotas.Size = new Size(115, 29);
            btnReadMascotas.TabIndex = 8;
            btnReadMascotas.Text = "Leer Mascotas";
            btnReadMascotas.UseVisualStyleBackColor = true;
            btnReadMascotas.Click += btnReadMascotas_Click;
            // 
            // btnSaveMascotas
            // 
            btnSaveMascotas.Location = new Point(259, 239);
            btnSaveMascotas.Name = "btnSaveMascotas";
            btnSaveMascotas.Size = new Size(115, 29);
            btnSaveMascotas.TabIndex = 9;
            btnSaveMascotas.Text = "Guardar Mascotas";
            btnSaveMascotas.UseVisualStyleBackColor = true;
            btnSaveMascotas.Click += btnSaveMascotas_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(419, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(483, 228);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(75, 23);
            btnExaminar.TabIndex = 11;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(646, 276);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnSaveMascotas);
            Controls.Add(btnReadMascotas);
            Controls.Add(Mascotas);
            Controls.Add(btnAddMascota);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtRaza);
            Controls.Add(lblRaza);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblRaza;
        private TextBox txtRaza;
        private Label lblEdad;
        private TextBox txtEdad;
        private Button btnAddMascota;
        private ListBox Mascotas;
        private Button btnReadMascotas;
        private Button btnSaveMascotas;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}
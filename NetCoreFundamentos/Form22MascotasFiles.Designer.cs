namespace NetCoreFundamentos
{
    partial class Form22MascotasFiles
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
            btnAddMascota = new Button();
            btnReadFileMascotas = new Button();
            btnWriteLista = new Button();
            lblNombre = new Label();
            lblRaza = new Label();
            Mascotas = new ListBox();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            lblListaMascotas = new Label();
            SuspendLayout();
            // 
            // btnAddMascota
            // 
            btnAddMascota.Location = new Point(37, 181);
            btnAddMascota.Name = "btnAddMascota";
            btnAddMascota.Size = new Size(100, 32);
            btnAddMascota.TabIndex = 0;
            btnAddMascota.Text = "Añadir Mascota";
            btnAddMascota.UseVisualStyleBackColor = true;
            btnAddMascota.Click += btnAddMascota_Click;
            // 
            // btnReadFileMascotas
            // 
            btnReadFileMascotas.Location = new Point(37, 219);
            btnReadFileMascotas.Name = "btnReadFileMascotas";
            btnReadFileMascotas.Size = new Size(100, 32);
            btnReadFileMascotas.TabIndex = 1;
            btnReadFileMascotas.Text = "Read Lista";
            btnReadFileMascotas.UseVisualStyleBackColor = true;
            btnReadFileMascotas.Click += btnReadFileMascotas_Click;
            // 
            // btnWriteLista
            // 
            btnWriteLista.Location = new Point(37, 257);
            btnWriteLista.Name = "btnWriteLista";
            btnWriteLista.Size = new Size(100, 32);
            btnWriteLista.TabIndex = 2;
            btnWriteLista.Text = "Write lista";
            btnWriteLista.UseVisualStyleBackColor = true;
            btnWriteLista.Click += btnWriteLista_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(37, 111);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(31, 15);
            lblRaza.TabIndex = 4;
            lblRaza.Text = "Raza";
            // 
            // Mascotas
            // 
            Mascotas.FormattingEnabled = true;
            Mascotas.Location = new Point(192, 76);
            Mascotas.Name = "Mascotas";
            Mascotas.Size = new Size(120, 214);
            Mascotas.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(37, 129);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 7;
            // 
            // lblListaMascotas
            // 
            lblListaMascotas.AutoSize = true;
            lblListaMascotas.Location = new Point(192, 58);
            lblListaMascotas.Name = "lblListaMascotas";
            lblListaMascotas.Size = new Size(31, 15);
            lblListaMascotas.TabIndex = 8;
            lblListaMascotas.Text = "Lista";
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(492, 450);
            Controls.Add(lblListaMascotas);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(Mascotas);
            Controls.Add(lblRaza);
            Controls.Add(lblNombre);
            Controls.Add(btnWriteLista);
            Controls.Add(btnReadFileMascotas);
            Controls.Add(btnAddMascota);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddMascota;
        private Button btnReadFileMascotas;
        private Button btnWriteLista;
        private Label lblNombre;
        private Label lblRaza;
        private ListBox Mascotas;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label lblListaMascotas;
    }
}
namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            btnLeerClase = new Button();
            btnGuardarClase = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(39, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(39, 85);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(31, 15);
            lblRaza.TabIndex = 2;
            lblRaza.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(97, 82);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(39, 114);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(97, 111);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(214, 66);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(93, 23);
            btnLeerClase.TabIndex = 6;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(214, 95);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(93, 23);
            btnGuardarClase.TabIndex = 7;
            btnGuardarClase.Text = "Guardar Clase";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(58, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(122, 380);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(75, 23);
            btnExaminar.TabIndex = 9;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(333, 442);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardarClase);
            Controls.Add(btnLeerClase);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtRaza);
            Controls.Add(lblRaza);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
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
        private Button btnLeerClase;
        private Button btnGuardarClase;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}
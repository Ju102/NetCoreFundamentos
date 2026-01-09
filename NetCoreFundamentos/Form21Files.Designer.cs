namespace NetCoreFundamentos
{
    partial class Form21Files
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
            txtContenidoFile = new TextBox();
            lblContenido = new Label();
            txtNuevoNombre = new TextBox();
            lblNombre = new Label();
            btnNuevoNombre = new Button();
            btnLeerFile = new Button();
            btnEscribirFile = new Button();
            lblNombres = new Label();
            Lista = new ListBox();
            SuspendLayout();
            // 
            // txtContenidoFile
            // 
            txtContenidoFile.Location = new Point(21, 52);
            txtContenidoFile.Multiline = true;
            txtContenidoFile.Name = "txtContenidoFile";
            txtContenidoFile.Size = new Size(193, 259);
            txtContenidoFile.TabIndex = 0;
            // 
            // lblContenido
            // 
            lblContenido.AutoSize = true;
            lblContenido.Location = new Point(21, 34);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(63, 15);
            lblContenido.TabIndex = 1;
            lblContenido.Text = "Contenido";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(245, 52);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(100, 23);
            txtNuevoNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(245, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(245, 90);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(100, 23);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo Nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnLeerFile
            // 
            btnLeerFile.Location = new Point(245, 119);
            btnLeerFile.Name = "btnLeerFile";
            btnLeerFile.Size = new Size(100, 23);
            btnLeerFile.TabIndex = 5;
            btnLeerFile.Text = "Leer";
            btnLeerFile.UseVisualStyleBackColor = true;
            btnLeerFile.Click += btnLeerFile_Click;
            // 
            // btnEscribirFile
            // 
            btnEscribirFile.Location = new Point(245, 148);
            btnEscribirFile.Name = "btnEscribirFile";
            btnEscribirFile.Size = new Size(100, 23);
            btnEscribirFile.TabIndex = 6;
            btnEscribirFile.Text = "Escribir";
            btnEscribirFile.UseVisualStyleBackColor = true;
            btnEscribirFile.Click += btnEscribirFile_Click;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(374, 34);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(56, 15);
            lblNombres.TabIndex = 8;
            lblNombres.Text = "Nombres";
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.Location = new Point(374, 52);
            Lista.Name = "Lista";
            Lista.Size = new Size(193, 259);
            Lista.TabIndex = 9;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(595, 388);
            Controls.Add(Lista);
            Controls.Add(lblNombres);
            Controls.Add(btnEscribirFile);
            Controls.Add(btnLeerFile);
            Controls.Add(btnNuevoNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtNuevoNombre);
            Controls.Add(lblContenido);
            Controls.Add(txtContenidoFile);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenidoFile;
        private Label lblContenido;
        private TextBox txtNuevoNombre;
        private Label lblNombre;
        private Button btnNuevoNombre;
        private Button btnLeerFile;
        private Button btnEscribirFile;
        private Label lblNombres;
        private ListBox Lista;
    }
}
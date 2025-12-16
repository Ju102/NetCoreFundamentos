namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            btnMostrar = new Button();
            btnGenerar = new Button();
            lstNumeros = new ListBox();
            lblNumeros = new Label();
            lblSuma = new Label();
            txtSumaTotal = new TextBox();
            lblPares = new Label();
            txtPares = new TextBox();
            lblImpar = new Label();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(138, 224);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(96, 23);
            btnMostrar.TabIndex = 24;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(36, 224);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(96, 23);
            btnGenerar.TabIndex = 23;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.AccessibleName = "";
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(36, 49);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(198, 169);
            lstNumeros.TabIndex = 20;
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(36, 31);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(102, 15);
            lblNumeros.TabIndex = 19;
            lblNumeros.Text = "Lista de Números:";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(36, 272);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(40, 15);
            lblSuma.TabIndex = 25;
            lblSuma.Text = "Suma:";
            // 
            // txtSumaTotal
            // 
            txtSumaTotal.Location = new Point(134, 269);
            txtSumaTotal.Name = "txtSumaTotal";
            txtSumaTotal.Size = new Size(100, 23);
            txtSumaTotal.TabIndex = 26;
            // 
            // lblPares
            // 
            lblPares.AutoSize = true;
            lblPares.Location = new Point(38, 301);
            lblPares.Name = "lblPares";
            lblPares.Size = new Size(38, 15);
            lblPares.TabIndex = 27;
            lblPares.Text = "Pares:";
            // 
            // txtPares
            // 
            txtPares.Location = new Point(134, 298);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 28;
            // 
            // lblImpar
            // 
            lblImpar.AutoSize = true;
            lblImpar.Location = new Point(38, 330);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new Size(52, 15);
            lblImpar.TabIndex = 29;
            lblImpar.Text = "Impares:";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(134, 327);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 30;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(272, 388);
            Controls.Add(txtImpares);
            Controls.Add(lblImpar);
            Controls.Add(txtPares);
            Controls.Add(lblPares);
            Controls.Add(txtSumaTotal);
            Controls.Add(lblSuma);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(lblNumeros);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMostrar;
        private Button btnGenerar;
        private ListBox lstNumeros;
        private Label lblNumeros;
        private Label lblSuma;
        private TextBox txtSumaTotal;
        private Label lblPares;
        private TextBox txtPares;
        private Label lblImpar;
        private TextBox txtImpares;
    }
}
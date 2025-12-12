namespace NetCoreFundamentos
{
    partial class Form01SumarNumeros
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
            lblNumero1 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblNumero2 = new Label();
            btnSumar = new Button();
            lblResultado = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(34, 44);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(123, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Introduce un número:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(34, 62);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(123, 23);
            txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(34, 135);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(123, 23);
            txtNumero2.TabIndex = 3;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(34, 117);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(131, 15);
            lblNumero2.TabIndex = 2;
            lblNumero2.Text = "Introduce otro número:";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(55, 181);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 4;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(63, 235);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(34, 253);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(123, 23);
            txtResultado.TabIndex = 6;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(186, 301);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(lblNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblNumero2;
        private Button btnSumar;
        private Label lblResultado;
        private TextBox txtResultado;
    }
}
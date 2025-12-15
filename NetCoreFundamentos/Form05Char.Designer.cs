namespace NetCoreFundamentos
{
    partial class Form05Char
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
            lblLetras = new Label();
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            label1 = new Label();
            txtSimbolos = new TextBox();
            label2 = new Label();
            txtPuntuacion = new TextBox();
            label3 = new Label();
            btnAscii = new Button();
            SuspendLayout();
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Location = new Point(25, 41);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(41, 15);
            lblLetras.TabIndex = 0;
            lblLetras.Text = "Letras:";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(25, 59);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(227, 145);
            txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(320, 59);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(227, 145);
            txtNumeros.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Números:";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(25, 239);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(227, 145);
            txtSimbolos.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 221);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Símbolos:";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(320, 239);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(227, 145);
            txtPuntuacion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 221);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 6;
            label3.Text = "Puntuación:";
            // 
            // btnAscii
            // 
            btnAscii.Location = new Point(222, 416);
            btnAscii.Name = "btnAscii";
            btnAscii.Size = new Size(133, 38);
            btnAscii.TabIndex = 8;
            btnAscii.Text = "Run ASCII";
            btnAscii.UseVisualStyleBackColor = true;
            btnAscii.Click += btnAscii_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(614, 513);
            Controls.Add(btnAscii);
            Controls.Add(txtPuntuacion);
            Controls.Add(label3);
            Controls.Add(txtSimbolos);
            Controls.Add(label2);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Controls.Add(txtLetras);
            Controls.Add(lblLetras);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLetras;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label label1;
        private TextBox txtSimbolos;
        private Label label2;
        private TextBox txtPuntuacion;
        private Label label3;
        private Button btnAscii;
    }
}
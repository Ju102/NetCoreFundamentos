namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            lblNumeros = new Label();
            txtNumeros = new TextBox();
            button1 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(36, 56);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(111, 15);
            lblNumeros.TabIndex = 0;
            lblNumeros.Text = "Introduce números:";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(36, 74);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(208, 23);
            txtNumeros.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(94, 121);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Sumar números";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(36, 173);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 450);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(txtNumeros);
            Controls.Add(lblNumeros);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeros;
        private TextBox txtNumeros;
        private Button button1;
        private Label lblResultado;
    }
}
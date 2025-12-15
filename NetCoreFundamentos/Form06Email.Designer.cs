namespace NetCoreFundamentos
{
    partial class Form06Email
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
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnEmail = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(42, 97);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(107, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Introduce tu email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(155, 134);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(75, 23);
            btnEmail.TabIndex = 2;
            btnEmail.Text = "Validar";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(111, 192);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form06Email
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 346);
            Controls.Add(lblResultado);
            Controls.Add(btnEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "Form06Email";
            Text = "Form06Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnEmail;
        private Label lblResultado;
    }
}
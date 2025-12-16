namespace NetCoreFundamentos
{
    partial class Form09ISBN
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
            lblISBN = new Label();
            txtISBN = new TextBox();
            btnISBN = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(26, 67);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(106, 15);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "Introduzca el ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(138, 64);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(147, 23);
            txtISBN.TabIndex = 1;
            // 
            // btnISBN
            // 
            btnISBN.Location = new Point(103, 109);
            btnISBN.Name = "btnISBN";
            btnISBN.Size = new Size(82, 23);
            btnISBN.TabIndex = 2;
            btnISBN.Text = "Comprobar";
            btnISBN.UseVisualStyleBackColor = true;
            btnISBN.Click += btnISBN_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(103, 164);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form09ISBN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(318, 276);
            Controls.Add(lblResultado);
            Controls.Add(btnISBN);
            Controls.Add(txtISBN);
            Controls.Add(lblISBN);
            Name = "Form09ISBN";
            Text = "Validación de ISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblISBN;
        private TextBox txtISBN;
        private Button btnISBN;
        private Label lblResultado;
    }
}
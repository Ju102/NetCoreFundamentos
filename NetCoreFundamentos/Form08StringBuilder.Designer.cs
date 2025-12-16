namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            lblTexto = new Label();
            txtTexto = new RichTextBox();
            lblTiempo = new Label();
            btnInvertir = new Button();
            btnInvertirStringBuilder = new Button();
            txtResultado = new RichTextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(28, 31);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(140, 15);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Copie texto para trabajar:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(28, 49);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(367, 138);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(164, 417);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 15);
            lblTiempo.TabIndex = 2;
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(101, 377);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(100, 23);
            btnInvertir.TabIndex = 3;
            btnInvertir.Text = "Invertir String";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(207, 377);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(125, 23);
            btnInvertirStringBuilder.TabIndex = 4;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(28, 219);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(367, 138);
            txtResultado.TabIndex = 6;
            txtResultado.Text = "";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(28, 201);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(140, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Copie texto para trabajar:";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(423, 450);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertir);
            Controls.Add(lblTiempo);
            Controls.Add(txtTexto);
            Controls.Add(lblTexto);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private RichTextBox txtTexto;
        private Label lblTiempo;
        private Button btnInvertir;
        private Button btnInvertirStringBuilder;
        private RichTextBox txtResultado;
        private Label lblResultado;
    }
}
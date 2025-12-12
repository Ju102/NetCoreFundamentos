namespace NetCoreFundamentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNombre = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(54, 82);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(75, 23);
            btnNombre.TabIndex = 0;
            btnNombre.Text = "Enviar";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(29, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(126, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Introduzca su nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(126, 23);
            txtNombre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(187, 179);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnNombre);
            Name = "Form1";
            Text = "klk manin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNombre;
        private Label lblNombre;
        private TextBox txtNombre;
    }
}

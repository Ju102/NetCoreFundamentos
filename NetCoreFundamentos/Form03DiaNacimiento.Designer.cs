namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            lblDiaNacimiento = new Label();
            lblMesNacimiento = new Label();
            lblYearNacimiento = new Label();
            txtDiaNacimiento = new TextBox();
            txtMesNacimiento = new TextBox();
            txtYearNacimiento = new TextBox();
            btnFechaNacimiento = new Button();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // lblDiaNacimiento
            // 
            lblDiaNacimiento.AutoSize = true;
            lblDiaNacimiento.ForeColor = SystemColors.Control;
            lblDiaNacimiento.Location = new Point(93, 49);
            lblDiaNacimiento.Name = "lblDiaNacimiento";
            lblDiaNacimiento.Size = new Size(27, 15);
            lblDiaNacimiento.TabIndex = 0;
            lblDiaNacimiento.Text = "Día:";
            // 
            // lblMesNacimiento
            // 
            lblMesNacimiento.AutoSize = true;
            lblMesNacimiento.ForeColor = SystemColors.Control;
            lblMesNacimiento.Location = new Point(93, 78);
            lblMesNacimiento.Name = "lblMesNacimiento";
            lblMesNacimiento.Size = new Size(32, 15);
            lblMesNacimiento.TabIndex = 1;
            lblMesNacimiento.Text = "Mes:";
            // 
            // lblYearNacimiento
            // 
            lblYearNacimiento.AutoSize = true;
            lblYearNacimiento.ForeColor = SystemColors.Control;
            lblYearNacimiento.Location = new Point(93, 107);
            lblYearNacimiento.Name = "lblYearNacimiento";
            lblYearNacimiento.Size = new Size(32, 15);
            lblYearNacimiento.TabIndex = 2;
            lblYearNacimiento.Text = "Año:";
            // 
            // txtDiaNacimiento
            // 
            txtDiaNacimiento.Location = new Point(139, 46);
            txtDiaNacimiento.Name = "txtDiaNacimiento";
            txtDiaNacimiento.Size = new Size(100, 23);
            txtDiaNacimiento.TabIndex = 3;
            // 
            // txtMesNacimiento
            // 
            txtMesNacimiento.Location = new Point(139, 75);
            txtMesNacimiento.Name = "txtMesNacimiento";
            txtMesNacimiento.Size = new Size(100, 23);
            txtMesNacimiento.TabIndex = 4;
            // 
            // txtYearNacimiento
            // 
            txtYearNacimiento.Location = new Point(139, 104);
            txtYearNacimiento.Name = "txtYearNacimiento";
            txtYearNacimiento.Size = new Size(100, 23);
            txtYearNacimiento.TabIndex = 5;
            // 
            // btnFechaNacimiento
            // 
            btnFechaNacimiento.Location = new Point(126, 150);
            btnFechaNacimiento.Name = "btnFechaNacimiento";
            btnFechaNacimiento.Size = new Size(75, 23);
            btnFechaNacimiento.TabIndex = 6;
            btnFechaNacimiento.Text = "Mostrar día";
            btnFechaNacimiento.UseVisualStyleBackColor = true;
            btnFechaNacimiento.Click += btnFechaNacimiento_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.ForeColor = SystemColors.ButtonFace;
            lblDiaSemana.Location = new Point(80, 197);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(0, 15);
            lblDiaSemana.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(338, 242);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnFechaNacimiento);
            Controls.Add(txtYearNacimiento);
            Controls.Add(txtMesNacimiento);
            Controls.Add(txtDiaNacimiento);
            Controls.Add(lblYearNacimiento);
            Controls.Add(lblMesNacimiento);
            Controls.Add(lblDiaNacimiento);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiaNacimiento;
        private Label lblMesNacimiento;
        private Label lblYearNacimiento;
        private TextBox txtDiaNacimiento;
        private TextBox txtMesNacimiento;
        private TextBox txtYearNacimiento;
        private Button btnFechaNacimiento;
        private Label lblDiaSemana;
    }
}
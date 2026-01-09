namespace NetCoreFundamentos
{
    partial class Form20TestClases
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
            lblDatos = new Label();
            Lista = new ListBox();
            btnCrear = new Button();
            btnCrearEmpleado = new Button();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Location = new Point(23, 12);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(40, 15);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "Datos:";
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.Location = new Point(23, 30);
            Lista.Name = "Lista";
            Lista.Size = new Size(440, 94);
            Lista.TabIndex = 1;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(79, 140);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(110, 23);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear Persona";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Location = new Point(208, 140);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(110, 23);
            btnCrearEmpleado.TabIndex = 3;
            btnCrearEmpleado.Text = "Crear Empleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 185);
            Controls.Add(btnCrearEmpleado);
            Controls.Add(btnCrear);
            Controls.Add(Lista);
            Controls.Add(lblDatos);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private ListBox Lista;
        private Button btnCrear;
        private Button btnCrearEmpleado;
    }
}
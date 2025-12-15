namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            lblFechaActual = new Label();
            txtFechaActual = new TextBox();
            chkFormatoFecha = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbYears = new RadioButton();
            lblncremento = new Label();
            txtIncremento = new TextBox();
            lblFechaFinal = new Label();
            txtFechaFinal = new TextBox();
            btnIncrementar = new Button();
            SuspendLayout();
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaActual.Location = new Point(30, 30);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(79, 15);
            lblFechaActual.TabIndex = 0;
            lblFechaActual.Text = "Fecha actual: ";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(30, 48);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.ReadOnly = true;
            txtFechaActual.Size = new Size(241, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormatoFecha
            // 
            chkFormatoFecha.AutoSize = true;
            chkFormatoFecha.ForeColor = SystemColors.ActiveCaptionText;
            chkFormatoFecha.Location = new Point(30, 77);
            chkFormatoFecha.Name = "chkFormatoFecha";
            chkFormatoFecha.Size = new Size(117, 19);
            chkFormatoFecha.TabIndex = 2;
            chkFormatoFecha.Text = "Cambiar formato";
            chkFormatoFecha.UseVisualStyleBackColor = true;
            chkFormatoFecha.CheckedChanged += chkFormatoFecha_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Checked = true;
            rdbDias.ForeColor = SystemColors.ActiveCaptionText;
            rdbDias.Location = new Point(30, 113);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.ForeColor = SystemColors.ActiveCaptionText;
            rdbMeses.Location = new Point(30, 138);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 4;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbYears
            // 
            rdbYears.AutoSize = true;
            rdbYears.ForeColor = SystemColors.ActiveCaptionText;
            rdbYears.Location = new Point(30, 163);
            rdbYears.Name = "rdbYears";
            rdbYears.Size = new Size(52, 19);
            rdbYears.TabIndex = 5;
            rdbYears.Text = "Años";
            rdbYears.UseVisualStyleBackColor = true;
            // 
            // lblncremento
            // 
            lblncremento.AutoSize = true;
            lblncremento.ForeColor = SystemColors.ActiveCaptionText;
            lblncremento.Location = new Point(117, 165);
            lblncremento.Name = "lblncremento";
            lblncremento.Size = new Size(74, 15);
            lblncremento.TabIndex = 6;
            lblncremento.Text = "Incremento: ";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(197, 159);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(74, 23);
            txtIncremento.TabIndex = 7;
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaFinal.Location = new Point(30, 224);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(67, 15);
            lblFechaFinal.TabIndex = 8;
            lblFechaFinal.Text = "Fecha final:";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(30, 242);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.ReadOnly = true;
            txtFechaFinal.Size = new Size(241, 23);
            txtFechaFinal.TabIndex = 9;
            // 
            // btnIncrementar
            // 
            btnIncrementar.ForeColor = SystemColors.ActiveCaptionText;
            btnIncrementar.Location = new Point(145, 188);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(88, 23);
            btnIncrementar.TabIndex = 10;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(303, 293);
            Controls.Add(btnIncrementar);
            Controls.Add(txtFechaFinal);
            Controls.Add(lblFechaFinal);
            Controls.Add(txtIncremento);
            Controls.Add(lblncremento);
            Controls.Add(rdbYears);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(chkFormatoFecha);
            Controls.Add(txtFechaActual);
            Controls.Add(lblFechaActual);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaActual;
        private TextBox txtFechaActual;
        private CheckBox chkFormatoFecha;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbYears;
        private Label lblncremento;
        private TextBox txtIncremento;
        private Label lblFechaFinal;
        private TextBox txtFechaFinal;
        private Button btnIncrementar;
    }
}
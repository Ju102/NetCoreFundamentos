namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            txtResultado = new TextBox();
            lblResultado = new Label();
            lblRaton = new Label();
            lblNumeros = new Label();
            txtNumeros = new TextBox();
            txtLetras = new TextBox();
            label1 = new Label();
            grpEventos = new GroupBox();
            grpMetodos = new GroupBox();
            grpEventos.SuspendLayout();
            grpMetodos.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(17, 20);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(17, 38);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(131, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(174, 38);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(136, 23);
            btnDobleValor.TabIndex = 2;
            btnDobleValor.Text = "Doble por Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(174, 67);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(136, 23);
            btnDobleReferencia.TabIndex = 3;
            btnDobleReferencia.Text = "Doble por Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(174, 96);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(136, 23);
            btnObjetoReferencia.TabIndex = 4;
            btnObjetoReferencia.Text = "Objeto referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(17, 96);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(131, 23);
            txtResultado.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(17, 78);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado:";
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.FromArgb(0, 192, 0);
            lblRaton.Location = new Point(174, 23);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(136, 123);
            lblRaton.TabIndex = 7;
            lblRaton.Text = "Ratón";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(17, 37);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(85, 15);
            lblNumeros.TabIndex = 8;
            lblNumeros.Text = "Solo Números:";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(17, 55);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(131, 23);
            txtNumeros.TabIndex = 9;
            txtNumeros.KeyPress += txtNumeros_KeyPress;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(17, 106);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(131, 23);
            txtLetras.TabIndex = 11;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 88);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 10;
            label1.Text = "Solo Letras:";
            // 
            // grpEventos
            // 
            grpEventos.Controls.Add(txtNumeros);
            grpEventos.Controls.Add(txtLetras);
            grpEventos.Controls.Add(lblRaton);
            grpEventos.Controls.Add(label1);
            grpEventos.Controls.Add(lblNumeros);
            grpEventos.Location = new Point(12, 150);
            grpEventos.Name = "grpEventos";
            grpEventos.Size = new Size(321, 159);
            grpEventos.TabIndex = 12;
            grpEventos.TabStop = false;
            grpEventos.Text = "Eventos";
            // 
            // grpMetodos
            // 
            grpMetodos.Controls.Add(txtNumero);
            grpMetodos.Controls.Add(lblNumero);
            grpMetodos.Controls.Add(txtResultado);
            grpMetodos.Controls.Add(btnDobleValor);
            grpMetodos.Controls.Add(lblResultado);
            grpMetodos.Controls.Add(btnDobleReferencia);
            grpMetodos.Controls.Add(btnObjetoReferencia);
            grpMetodos.Location = new Point(12, 12);
            grpMetodos.Name = "grpMetodos";
            grpMetodos.Size = new Size(321, 132);
            grpMetodos.TabIndex = 13;
            grpMetodos.TabStop = false;
            grpMetodos.Text = "Métodos";
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(343, 333);
            Controls.Add(grpMetodos);
            Controls.Add(grpEventos);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            grpEventos.ResumeLayout(false);
            grpEventos.PerformLayout();
            grpMetodos.ResumeLayout(false);
            grpMetodos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private TextBox txtResultado;
        private Label lblResultado;
        private Label lblRaton;
        private Label lblNumeros;
        private TextBox txtNumeros;
        private TextBox txtLetras;
        private Label label1;
        private GroupBox grpEventos;
        private GroupBox grpMetodos;
    }
}
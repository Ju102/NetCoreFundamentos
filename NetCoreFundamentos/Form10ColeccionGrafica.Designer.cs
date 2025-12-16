namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            lblElementos = new Label();
            lstElementos = new ListBox();
            txtElemento = new TextBox();
            lblElemento = new Label();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnEliminarTodo = new Button();
            lblIndex = new Label();
            lblItem = new Label();
            SuspendLayout();
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Location = new Point(12, 54);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(105, 15);
            lblElementos.TabIndex = 0;
            lblElementos.Text = "Lista de Elementos";
            // 
            // lstElementos
            // 
            lstElementos.AccessibleName = "";
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 72);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(151, 169);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(197, 90);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(134, 23);
            txtElemento.TabIndex = 2;
            // 
            // lblElemento
            // 
            lblElemento.AutoSize = true;
            lblElemento.Location = new Point(197, 72);
            lblElemento.Name = "lblElemento";
            lblElemento.Size = new Size(134, 15);
            lblElemento.TabIndex = 3;
            lblElemento.Text = "Añadir nuevo elemento:";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(225, 128);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(225, 157);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.Location = new Point(225, 186);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(75, 23);
            btnEliminarTodo.TabIndex = 6;
            btnEliminarTodo.Text = "Limpiar";
            btnEliminarTodo.UseVisualStyleBackColor = true;
            btnEliminarTodo.Click += btnEliminarTodo_Click;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(12, 264);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(55, 15);
            lblIndex.TabIndex = 7;
            lblIndex.Text = "Posición:";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(12, 290);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 15);
            lblItem.TabIndex = 8;
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(345, 340);
            Controls.Add(lblItem);
            Controls.Add(lblIndex);
            Controls.Add(btnEliminarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(lblElemento);
            Controls.Add(txtElemento);
            Controls.Add(lstElementos);
            Controls.Add(lblElementos);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblElementos;
        private ListBox lstElementos;
        private TextBox txtElemento;
        private Label lblElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnEliminarTodo;
        private Label lblIndex;
        private Label lblItem;
    }
}
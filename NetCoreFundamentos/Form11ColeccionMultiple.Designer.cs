namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblItem = new Label();
            lblIndex = new Label();
            btnEliminarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            lblElemento = new Label();
            txtElemento = new TextBox();
            lstElementos = new ListBox();
            lblElementos = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(40, 264);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(39, 15);
            lblItem.TabIndex = 17;
            lblItem.Text = "Items:";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(40, 238);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(66, 15);
            lblIndex.TabIndex = 16;
            lblIndex.Text = "Posiciones:";
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.Location = new Point(243, 160);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(96, 23);
            btnEliminarTodo.TabIndex = 15;
            btnEliminarTodo.Text = "Limpiar";
            btnEliminarTodo.UseVisualStyleBackColor = true;
            btnEliminarTodo.Click += btnEliminarTodo_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(243, 131);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(243, 102);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(96, 23);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblElemento
            // 
            lblElemento.AutoSize = true;
            lblElemento.Location = new Point(225, 46);
            lblElemento.Name = "lblElemento";
            lblElemento.Size = new Size(134, 15);
            lblElemento.TabIndex = 12;
            lblElemento.Text = "Añadir nuevo elemento:";
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(225, 64);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(134, 23);
            txtElemento.TabIndex = 11;
            // 
            // lstElementos
            // 
            lstElementos.AccessibleName = "";
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(40, 46);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(151, 169);
            lstElementos.TabIndex = 10;
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Location = new Point(40, 28);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(105, 15);
            lblElementos.TabIndex = 9;
            lblElementos.Text = "Lista de Elementos";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(243, 189);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(96, 23);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.TextAlign = ContentAlignment.MiddleRight;
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(396, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblItem);
            Controls.Add(lblIndex);
            Controls.Add(btnEliminarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(lblElemento);
            Controls.Add(txtElemento);
            Controls.Add(lstElementos);
            Controls.Add(lblElementos);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItem;
        private Label lblIndex;
        private Button btnEliminarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private Label lblElemento;
        private TextBox txtElemento;
        private ListBox lstElementos;
        private Label lblElementos;
        private Button btnSeleccionados;
    }
}
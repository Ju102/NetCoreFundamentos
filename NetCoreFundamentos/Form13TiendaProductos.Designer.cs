namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            lblAddProducto = new Label();
            txtProducto = new TextBox();
            btnAddProducto = new Button();
            btnEliminarProducto = new Button();
            btnLimpiarLista = new Button();
            Tienda = new ListBox();
            grpTienda = new GroupBox();
            btnEnviarTienda = new Button();
            btnEnviarTiendaTodos = new Button();
            grpAlmacen = new GroupBox();
            btnBajar = new Button();
            btnSubir = new Button();
            Almacen = new ListBox();
            grpTienda.SuspendLayout();
            grpAlmacen.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddProducto
            // 
            lblAddProducto.AutoSize = true;
            lblAddProducto.Location = new Point(16, 22);
            lblAddProducto.Name = "lblAddProducto";
            lblAddProducto.Size = new Size(97, 15);
            lblAddProducto.TabIndex = 0;
            lblAddProducto.Text = "Añadir Producto:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(16, 40);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(142, 23);
            txtProducto.TabIndex = 1;
            // 
            // btnAddProducto
            // 
            btnAddProducto.Location = new Point(16, 80);
            btnAddProducto.Name = "btnAddProducto";
            btnAddProducto.Size = new Size(142, 23);
            btnAddProducto.TabIndex = 2;
            btnAddProducto.Text = "Añadir";
            btnAddProducto.UseVisualStyleBackColor = true;
            btnAddProducto.Click += btnAddProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(16, 109);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(142, 23);
            btnEliminarProducto.TabIndex = 3;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnLimpiarLista
            // 
            btnLimpiarLista.Location = new Point(16, 138);
            btnLimpiarLista.Name = "btnLimpiarLista";
            btnLimpiarLista.Size = new Size(142, 23);
            btnLimpiarLista.TabIndex = 4;
            btnLimpiarLista.Text = "Limpiar";
            btnLimpiarLista.UseVisualStyleBackColor = true;
            btnLimpiarLista.Click += btnLimpiarLista_Click;
            // 
            // Tienda
            // 
            Tienda.FormattingEnabled = true;
            Tienda.Location = new Point(173, 22);
            Tienda.Name = "Tienda";
            Tienda.Size = new Size(120, 139);
            Tienda.TabIndex = 6;
            // 
            // grpTienda
            // 
            grpTienda.Controls.Add(Tienda);
            grpTienda.Controls.Add(lblAddProducto);
            grpTienda.Controls.Add(btnLimpiarLista);
            grpTienda.Controls.Add(txtProducto);
            grpTienda.Controls.Add(btnEliminarProducto);
            grpTienda.Controls.Add(btnAddProducto);
            grpTienda.Location = new Point(22, 28);
            grpTienda.Name = "grpTienda";
            grpTienda.Size = new Size(309, 180);
            grpTienda.TabIndex = 7;
            grpTienda.TabStop = false;
            grpTienda.Text = "Tienda";
            // 
            // btnEnviarTienda
            // 
            btnEnviarTienda.Location = new Point(347, 93);
            btnEnviarTienda.Name = "btnEnviarTienda";
            btnEnviarTienda.Size = new Size(75, 23);
            btnEnviarTienda.TabIndex = 7;
            btnEnviarTienda.Text = "Selección";
            btnEnviarTienda.UseVisualStyleBackColor = true;
            btnEnviarTienda.Click += btnEnviarTienda_Click;
            // 
            // btnEnviarTiendaTodos
            // 
            btnEnviarTiendaTodos.Location = new Point(347, 122);
            btnEnviarTiendaTodos.Name = "btnEnviarTiendaTodos";
            btnEnviarTiendaTodos.Size = new Size(75, 23);
            btnEnviarTiendaTodos.TabIndex = 8;
            btnEnviarTiendaTodos.Text = "Todos";
            btnEnviarTiendaTodos.UseVisualStyleBackColor = true;
            btnEnviarTiendaTodos.Click += btnEnviarTiendaTodos_Click;
            // 
            // grpAlmacen
            // 
            grpAlmacen.Controls.Add(btnBajar);
            grpAlmacen.Controls.Add(btnSubir);
            grpAlmacen.Controls.Add(Almacen);
            grpAlmacen.Location = new Point(440, 28);
            grpAlmacen.Name = "grpAlmacen";
            grpAlmacen.Size = new Size(309, 180);
            grpAlmacen.TabIndex = 8;
            grpAlmacen.TabStop = false;
            grpAlmacen.Text = "Almacen";
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(149, 91);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(142, 23);
            btnBajar.TabIndex = 8;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(149, 62);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(142, 23);
            btnSubir.TabIndex = 7;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // Almacen
            // 
            Almacen.FormattingEnabled = true;
            Almacen.Location = new Point(17, 22);
            Almacen.Name = "Almacen";
            Almacen.Size = new Size(120, 139);
            Almacen.TabIndex = 6;
            Almacen.SelectedIndexChanged += Almacen_SelectedIndexChanged;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(776, 273);
            Controls.Add(grpAlmacen);
            Controls.Add(btnEnviarTienda);
            Controls.Add(btnEnviarTiendaTodos);
            Controls.Add(grpTienda);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            grpTienda.ResumeLayout(false);
            grpTienda.PerformLayout();
            grpAlmacen.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblAddProducto;
        private TextBox txtProducto;
        private Button btnAddProducto;
        private Button btnEliminarProducto;
        private Button btnLimpiarLista;
        private ListBox Tienda;
        private GroupBox grpTienda;
        private Button btnEnviarTienda;
        private Button btnEnviarTiendaTodos;
        private GroupBox grpAlmacen;
        private Button btnBajar;
        private Button btnSubir;
        private ListBox Almacen;
    }
}
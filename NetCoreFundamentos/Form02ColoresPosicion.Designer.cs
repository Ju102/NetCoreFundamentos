namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            grbPosicion = new GroupBox();
            btnPosicion = new Button();
            txtPosicionY = new TextBox();
            txtPosicionX = new TextBox();
            lblPosicionY = new Label();
            lblPosicionX = new Label();
            grbColor = new GroupBox();
            txtBlue = new TextBox();
            lblBlue = new Label();
            btnColor = new Button();
            txtGreen = new TextBox();
            txtRed = new TextBox();
            lblGreen = new Label();
            lblRed = new Label();
            lblTestPosicion = new Label();
            grbPosicion.SuspendLayout();
            grbColor.SuspendLayout();
            SuspendLayout();
            // 
            // grbPosicion
            // 
            grbPosicion.Controls.Add(btnPosicion);
            grbPosicion.Controls.Add(txtPosicionY);
            grbPosicion.Controls.Add(txtPosicionX);
            grbPosicion.Controls.Add(lblPosicionY);
            grbPosicion.Controls.Add(lblPosicionX);
            grbPosicion.Location = new Point(70, 36);
            grbPosicion.Name = "grbPosicion";
            grbPosicion.Size = new Size(127, 196);
            grbPosicion.TabIndex = 0;
            grbPosicion.TabStop = false;
            grbPosicion.Text = "Posición";
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(25, 137);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(75, 23);
            btnPosicion.TabIndex = 4;
            btnPosicion.Text = "Mover";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(82, 82);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(31, 23);
            txtPosicionY.TabIndex = 3;
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(82, 52);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(31, 23);
            txtPosicionX.TabIndex = 2;
            // 
            // lblPosicionY
            // 
            lblPosicionY.AutoSize = true;
            lblPosicionY.Location = new Point(14, 85);
            lblPosicionY.Name = "lblPosicionY";
            lblPosicionY.Size = new Size(62, 15);
            lblPosicionY.TabIndex = 1;
            lblPosicionY.Text = "Posición Y";
            // 
            // lblPosicionX
            // 
            lblPosicionX.AutoSize = true;
            lblPosicionX.Location = new Point(14, 55);
            lblPosicionX.Name = "lblPosicionX";
            lblPosicionX.Size = new Size(62, 15);
            lblPosicionX.TabIndex = 0;
            lblPosicionX.Text = "Posición X";
            // 
            // grbColor
            // 
            grbColor.Controls.Add(txtBlue);
            grbColor.Controls.Add(lblBlue);
            grbColor.Controls.Add(btnColor);
            grbColor.Controls.Add(txtGreen);
            grbColor.Controls.Add(txtRed);
            grbColor.Controls.Add(lblGreen);
            grbColor.Controls.Add(lblRed);
            grbColor.Location = new Point(220, 36);
            grbColor.Name = "grbColor";
            grbColor.Size = new Size(127, 196);
            grbColor.TabIndex = 5;
            grbColor.TabStop = false;
            grbColor.Text = "Color";
            // 
            // txtBlue
            // 
            txtBlue.Location = new Point(74, 85);
            txtBlue.Name = "txtBlue";
            txtBlue.Size = new Size(31, 23);
            txtBlue.TabIndex = 4;
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Location = new Point(6, 93);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(33, 15);
            lblBlue.TabIndex = 5;
            lblBlue.Text = "Blue:";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(30, 137);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 5;
            btnColor.Text = "Cambiar";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtGreen
            // 
            txtGreen.Location = new Point(74, 53);
            txtGreen.Name = "txtGreen";
            txtGreen.Size = new Size(31, 23);
            txtGreen.TabIndex = 3;
            // 
            // txtRed
            // 
            txtRed.Location = new Point(74, 23);
            txtRed.Name = "txtRed";
            txtRed.Size = new Size(31, 23);
            txtRed.TabIndex = 2;
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Location = new Point(6, 61);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(41, 15);
            lblGreen.TabIndex = 1;
            lblGreen.Text = "Green:";
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(6, 31);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(30, 15);
            lblRed.TabIndex = 0;
            lblRed.Text = "Red:";
            // 
            // lblTestPosicion
            // 
            lblTestPosicion.AutoSize = true;
            lblTestPosicion.Location = new Point(192, 315);
            lblTestPosicion.Name = "lblTestPosicion";
            lblTestPosicion.Size = new Size(29, 15);
            lblTestPosicion.TabIndex = 6;
            lblTestPosicion.Text = "RGB";
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(lblTestPosicion);
            Controls.Add(grbColor);
            Controls.Add(grbPosicion);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            grbPosicion.ResumeLayout(false);
            grbPosicion.PerformLayout();
            grbColor.ResumeLayout(false);
            grbColor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbPosicion;
        private Label lblPosicionY;
        private Label lblPosicionX;
        private TextBox txtPosicionY;
        private TextBox txtPosicionX;
        private Button btnPosicion;
        private GroupBox grbColor;
        private Button btnColor;
        private TextBox txtGreen;
        private TextBox txtRed;
        private Label lblGreen;
        private Label lblRed;
        private TextBox txtBlue;
        private Label lblBlue;
        private Label lblTestPosicion;
    }
}
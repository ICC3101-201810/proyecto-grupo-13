namespace WindowsFormsApp1
{
    partial class Form4
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
            this.ListProducts = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombre_local = new System.Windows.Forms.Label();
            this.agregar_quitar = new System.Windows.Forms.Button();
            this.Modificar_p = new System.Windows.Forms.Button();
            this.CreandoProductos = new System.Windows.Forms.ListBox();
            this.nombrep = new System.Windows.Forms.Label();
            this.PrecioP = new System.Windows.Forms.Label();
            this.Stockp = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.precio_text = new System.Windows.Forms.TextBox();
            this.stock_text = new System.Windows.Forms.TextBox();
            this.Agregarfinal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListProducts
            // 
            this.ListProducts.BackColor = System.Drawing.SystemColors.Desktop;
            this.ListProducts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProducts.ForeColor = System.Drawing.SystemColors.Window;
            this.ListProducts.FormattingEnabled = true;
            this.ListProducts.ItemHeight = 19;
            this.ListProducts.Location = new System.Drawing.Point(274, 121);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(423, 289);
            this.ListProducts.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LOGOFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(614, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nombre_local
            // 
            this.nombre_local.AutoSize = true;
            this.nombre_local.BackColor = System.Drawing.Color.Transparent;
            this.nombre_local.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_local.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombre_local.Location = new System.Drawing.Point(281, 82);
            this.nombre_local.Name = "nombre_local";
            this.nombre_local.Size = new System.Drawing.Size(0, 26);
            this.nombre_local.TabIndex = 2;
            // 
            // agregar_quitar
            // 
            this.agregar_quitar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_quitar.Location = new System.Drawing.Point(167, 434);
            this.agregar_quitar.Name = "agregar_quitar";
            this.agregar_quitar.Size = new System.Drawing.Size(224, 31);
            this.agregar_quitar.TabIndex = 3;
            this.agregar_quitar.Text = "Agregar Producto";
            this.agregar_quitar.UseVisualStyleBackColor = true;
            this.agregar_quitar.Click += new System.EventHandler(this.agregar_quitar_Click);
            // 
            // Modificar_p
            // 
            this.Modificar_p.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_p.Location = new System.Drawing.Point(407, 434);
            this.Modificar_p.Name = "Modificar_p";
            this.Modificar_p.Size = new System.Drawing.Size(224, 31);
            this.Modificar_p.TabIndex = 4;
            this.Modificar_p.Text = "Modificar Producto";
            this.Modificar_p.UseVisualStyleBackColor = true;
            this.Modificar_p.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreandoProductos
            // 
            this.CreandoProductos.FormattingEnabled = true;
            this.CreandoProductos.Location = new System.Drawing.Point(335, 145);
            this.CreandoProductos.Name = "CreandoProductos";
            this.CreandoProductos.Size = new System.Drawing.Size(296, 251);
            this.CreandoProductos.TabIndex = 5;
            // 
            // nombrep
            // 
            this.nombrep.AutoSize = true;
            this.nombrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrep.Location = new System.Drawing.Point(270, 25);
            this.nombrep.Name = "nombrep";
            this.nombrep.Size = new System.Drawing.Size(79, 24);
            this.nombrep.TabIndex = 6;
            this.nombrep.Text = "Nombre";
            // 
            // PrecioP
            // 
            this.PrecioP.AutoSize = true;
            this.PrecioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioP.Location = new System.Drawing.Point(270, 58);
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.Size = new System.Drawing.Size(64, 24);
            this.PrecioP.TabIndex = 7;
            this.PrecioP.Text = "Precio";
            // 
            // Stockp
            // 
            this.Stockp.AutoSize = true;
            this.Stockp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockp.Location = new System.Drawing.Point(270, 90);
            this.Stockp.Name = "Stockp";
            this.Stockp.Size = new System.Drawing.Size(56, 24);
            this.Stockp.TabIndex = 8;
            this.Stockp.Text = "Stock";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(374, 25);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(163, 20);
            this.nameText.TabIndex = 9;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            this.nameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombre_enter);
            // 
            // precio_text
            // 
            this.precio_text.Location = new System.Drawing.Point(374, 63);
            this.precio_text.Name = "precio_text";
            this.precio_text.Size = new System.Drawing.Size(163, 20);
            this.precio_text.TabIndex = 10;
            this.precio_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precio_enter);
            // 
            // stock_text
            // 
            this.stock_text.Location = new System.Drawing.Point(374, 95);
            this.stock_text.Name = "stock_text";
            this.stock_text.Size = new System.Drawing.Size(163, 20);
            this.stock_text.TabIndex = 11;
            this.stock_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stock_enter);
            // 
            // Agregarfinal
            // 
            this.Agregarfinal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarfinal.Location = new System.Drawing.Point(648, 145);
            this.Agregarfinal.Name = "Agregarfinal";
            this.Agregarfinal.Size = new System.Drawing.Size(104, 35);
            this.Agregarfinal.TabIndex = 12;
            this.Agregarfinal.Text = "Agregar";
            this.Agregarfinal.UseVisualStyleBackColor = true;
            this.Agregarfinal.Click += new System.EventHandler(this.Agregarfinal_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.food_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.Agregarfinal);
            this.Controls.Add(this.stock_text);
            this.Controls.Add(this.precio_text);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.Stockp);
            this.Controls.Add(this.PrecioP);
            this.Controls.Add(this.nombrep);
            this.Controls.Add(this.CreandoProductos);
            this.Controls.Add(this.Modificar_p);
            this.Controls.Add(this.agregar_quitar);
            this.Controls.Add(this.nombre_local);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListProducts);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nombre_local;
        private System.Windows.Forms.Button agregar_quitar;
        private System.Windows.Forms.Button Modificar_p;
        private System.Windows.Forms.ListBox CreandoProductos;
        private System.Windows.Forms.Label nombrep;
        private System.Windows.Forms.Label PrecioP;
        private System.Windows.Forms.Label Stockp;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox precio_text;
        private System.Windows.Forms.TextBox stock_text;
        private System.Windows.Forms.Button Agregarfinal;
    }
}
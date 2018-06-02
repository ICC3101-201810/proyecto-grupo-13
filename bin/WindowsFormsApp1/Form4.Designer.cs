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
            this.Modificar_p = new System.Windows.Forms.Button();
            this.nombrep = new System.Windows.Forms.Label();
            this.PrecioP = new System.Windows.Forms.Label();
            this.Stockp = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.precio_text = new System.Windows.Forms.TextBox();
            this.stock_text = new System.Windows.Forms.TextBox();
            this.Agregarfinal = new System.Windows.Forms.Button();
            this.eliminar_p = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListProducts
            // 
            this.ListProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListProducts.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProducts.ForeColor = System.Drawing.SystemColors.Window;
            this.ListProducts.FormattingEnabled = true;
            this.ListProducts.ItemHeight = 23;
            this.ListProducts.Location = new System.Drawing.Point(286, 186);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(423, 280);
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
            // Modificar_p
            // 
            this.Modificar_p.BackColor = System.Drawing.Color.Aquamarine;
            this.Modificar_p.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_p.Location = new System.Drawing.Point(715, 280);
            this.Modificar_p.Name = "Modificar_p";
            this.Modificar_p.Size = new System.Drawing.Size(172, 35);
            this.Modificar_p.TabIndex = 4;
            this.Modificar_p.Text = "Modificar Producto";
            this.Modificar_p.UseVisualStyleBackColor = false;
            this.Modificar_p.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombrep
            // 
            this.nombrep.AutoSize = true;
            this.nombrep.BackColor = System.Drawing.Color.Transparent;
            this.nombrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrep.ForeColor = System.Drawing.Color.White;
            this.nombrep.Location = new System.Drawing.Point(317, 77);
            this.nombrep.Name = "nombrep";
            this.nombrep.Size = new System.Drawing.Size(85, 24);
            this.nombrep.TabIndex = 6;
            this.nombrep.Text = "Nombre";
            // 
            // PrecioP
            // 
            this.PrecioP.AutoSize = true;
            this.PrecioP.BackColor = System.Drawing.Color.Transparent;
            this.PrecioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrecioP.Location = new System.Drawing.Point(324, 113);
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.Size = new System.Drawing.Size(70, 24);
            this.PrecioP.TabIndex = 7;
            this.PrecioP.Text = "Precio";
            // 
            // Stockp
            // 
            this.Stockp.AutoSize = true;
            this.Stockp.BackColor = System.Drawing.Color.Transparent;
            this.Stockp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockp.ForeColor = System.Drawing.Color.White;
            this.Stockp.Location = new System.Drawing.Point(330, 151);
            this.Stockp.Name = "Stockp";
            this.Stockp.Size = new System.Drawing.Size(61, 24);
            this.Stockp.TabIndex = 8;
            this.Stockp.Text = "Stock";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.ForeColor = System.Drawing.Color.Cyan;
            this.nameText.Location = new System.Drawing.Point(408, 75);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(163, 26);
            this.nameText.TabIndex = 9;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            this.nameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombre_enter);
            // 
            // precio_text
            // 
            this.precio_text.BackColor = System.Drawing.Color.Gray;
            this.precio_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_text.ForeColor = System.Drawing.Color.Cyan;
            this.precio_text.Location = new System.Drawing.Point(408, 114);
            this.precio_text.Name = "precio_text";
            this.precio_text.Size = new System.Drawing.Size(163, 26);
            this.precio_text.TabIndex = 10;
            this.precio_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precio_enter);
            // 
            // stock_text
            // 
            this.stock_text.BackColor = System.Drawing.Color.Silver;
            this.stock_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_text.ForeColor = System.Drawing.Color.Cyan;
            this.stock_text.Location = new System.Drawing.Point(408, 151);
            this.stock_text.Name = "stock_text";
            this.stock_text.Size = new System.Drawing.Size(163, 26);
            this.stock_text.TabIndex = 11;
            this.stock_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stock_enter);
            // 
            // Agregarfinal
            // 
            this.Agregarfinal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Agregarfinal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarfinal.Location = new System.Drawing.Point(715, 189);
            this.Agregarfinal.Name = "Agregarfinal";
            this.Agregarfinal.Size = new System.Drawing.Size(172, 35);
            this.Agregarfinal.TabIndex = 12;
            this.Agregarfinal.Text = "Agregar Producto";
            this.Agregarfinal.UseVisualStyleBackColor = false;
            this.Agregarfinal.Click += new System.EventHandler(this.Agregarfinal_Click);
            // 
            // eliminar_p
            // 
            this.eliminar_p.BackColor = System.Drawing.Color.GreenYellow;
            this.eliminar_p.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_p.Location = new System.Drawing.Point(715, 232);
            this.eliminar_p.Name = "eliminar_p";
            this.eliminar_p.Size = new System.Drawing.Size(172, 35);
            this.eliminar_p.TabIndex = 13;
            this.eliminar_p.Text = "Quitar Producto";
            this.eliminar_p.UseVisualStyleBackColor = false;
            this.eliminar_p.Click += new System.EventHandler(this.eliminar_p_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.food_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar_p);
            this.Controls.Add(this.Agregarfinal);
            this.Controls.Add(this.stock_text);
            this.Controls.Add(this.precio_text);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.Stockp);
            this.Controls.Add(this.PrecioP);
            this.Controls.Add(this.nombrep);
            this.Controls.Add(this.Modificar_p);
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
        private System.Windows.Forms.Button Modificar_p;
        private System.Windows.Forms.Label nombrep;
        private System.Windows.Forms.Label PrecioP;
        private System.Windows.Forms.Label Stockp;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox precio_text;
        private System.Windows.Forms.TextBox stock_text;
        private System.Windows.Forms.Button Agregarfinal;
        private System.Windows.Forms.Button eliminar_p;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace WindowsFormsApp1
{
    partial class Form7
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productos = new System.Windows.Forms.ListBox();
            this.carrito = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.p_acumulado = new System.Windows.Forms.Label();
            this.selecc_p = new System.Windows.Forms.Button();
            this.volver_locales = new System.Windows.Forms.Button();
            this.Precio_p = new System.Windows.Forms.ListBox();
            this.Stock_p = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Nombre_p = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LOGOFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // productos
            // 
            this.productos.BackColor = System.Drawing.Color.SeaGreen;
            this.productos.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productos.ForeColor = System.Drawing.Color.Black;
            this.productos.FormattingEnabled = true;
            this.productos.ItemHeight = 23;
            this.productos.Location = new System.Drawing.Point(12, 226);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(209, 349);
            this.productos.TabIndex = 6;
            // 
            // carrito
            // 
            this.carrito.BackColor = System.Drawing.Color.Transparent;
            this.carrito.Image = global::WindowsFormsApp1.Properties.Resources.carrito;
            this.carrito.Location = new System.Drawing.Point(761, 18);
            this.carrito.Name = "carrito";
            this.carrito.Size = new System.Drawing.Size(98, 85);
            this.carrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carrito.TabIndex = 7;
            this.carrito.TabStop = false;
            this.carrito.Click += new System.EventHandler(this.carrrito_click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.pegatina_circulo_rojo;
            this.pictureBox2.Location = new System.Drawing.Point(836, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // p_acumulado
            // 
            this.p_acumulado.AutoSize = true;
            this.p_acumulado.BackColor = System.Drawing.Color.Transparent;
            this.p_acumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_acumulado.ForeColor = System.Drawing.Color.White;
            this.p_acumulado.Image = global::WindowsFormsApp1.Properties.Resources.pegatina_circulo_rojo;
            this.p_acumulado.Location = new System.Drawing.Point(850, 53);
            this.p_acumulado.Name = "p_acumulado";
            this.p_acumulado.Size = new System.Drawing.Size(30, 31);
            this.p_acumulado.TabIndex = 9;
            this.p_acumulado.Text = "0";
            this.p_acumulado.Click += new System.EventHandler(this.p_acumulado_Click);
            // 
            // selecc_p
            // 
            this.selecc_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecc_p.Image = global::WindowsFormsApp1.Properties.Resources.depositphotos_149002667_stock_photo_fresh_tasty_italian_pizza_fast;
            this.selecc_p.Location = new System.Drawing.Point(694, 226);
            this.selecc_p.Name = "selecc_p";
            this.selecc_p.Size = new System.Drawing.Size(186, 67);
            this.selecc_p.TabIndex = 10;
            this.selecc_p.Text = "Seleccionar Producto";
            this.selecc_p.UseVisualStyleBackColor = true;
            this.selecc_p.Click += new System.EventHandler(this.selecc_p_Click);
            // 
            // volver_locales
            // 
            this.volver_locales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver_locales.Image = global::WindowsFormsApp1.Properties.Resources.depositphotos_149002667_stock_photo_fresh_tasty_italian_pizza_fast;
            this.volver_locales.Location = new System.Drawing.Point(694, 332);
            this.volver_locales.Name = "volver_locales";
            this.volver_locales.Size = new System.Drawing.Size(186, 67);
            this.volver_locales.TabIndex = 11;
            this.volver_locales.Text = "Volver a Locales";
            this.volver_locales.UseVisualStyleBackColor = true;
            this.volver_locales.Click += new System.EventHandler(this.volver_locales_Click);
            // 
            // Precio_p
            // 
            this.Precio_p.BackColor = System.Drawing.Color.PaleGreen;
            this.Precio_p.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_p.ForeColor = System.Drawing.Color.Black;
            this.Precio_p.FormattingEnabled = true;
            this.Precio_p.ItemHeight = 23;
            this.Precio_p.Location = new System.Drawing.Point(225, 226);
            this.Precio_p.Name = "Precio_p";
            this.Precio_p.Size = new System.Drawing.Size(209, 349);
            this.Precio_p.TabIndex = 12;
            // 
            // Stock_p
            // 
            this.Stock_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Stock_p.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_p.ForeColor = System.Drawing.Color.Black;
            this.Stock_p.FormattingEnabled = true;
            this.Stock_p.ItemHeight = 23;
            this.Stock_p.Location = new System.Drawing.Point(438, 226);
            this.Stock_p.Name = "Stock_p";
            this.Stock_p.Size = new System.Drawing.Size(209, 349);
            this.Stock_p.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Local Ubicado en:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 51);
            this.label2.TabIndex = 15;
            this.label2.Text = "Delivery:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.info_309081_960_720;
            this.pictureBox3.Location = new System.Drawing.Point(749, 457);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseHover += new System.EventHandler(this.Info);
            // 
            // Nombre_p
            // 
            this.Nombre_p.AutoSize = true;
            this.Nombre_p.BackColor = System.Drawing.Color.Transparent;
            this.Nombre_p.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_p.Location = new System.Drawing.Point(13, 185);
            this.Nombre_p.Name = "Nombre_p";
            this.Nombre_p.Size = new System.Drawing.Size(101, 37);
            this.Nombre_p.TabIndex = 17;
            this.Nombre_p.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stock";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.food;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre_p);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stock_p);
            this.Controls.Add(this.Precio_p);
            this.Controls.Add(this.volver_locales);
            this.Controls.Add(this.selecc_p);
            this.Controls.Add(this.p_acumulado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.carrito);
            this.Controls.Add(this.productos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox productos;
        private System.Windows.Forms.PictureBox carrito;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button selecc_p;
        private System.Windows.Forms.Button volver_locales;
        private System.Windows.Forms.ListBox Precio_p;
        private System.Windows.Forms.ListBox Stock_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Nombre_p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label p_acumulado;
    }
}
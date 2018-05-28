namespace WindowsFormsApp1
{
    partial class Form2
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
            this.asAdmin = new System.Windows.Forms.Label();
            this.Rut_AdminVerificar = new System.Windows.Forms.Label();
            this.RUT_ADMIN = new System.Windows.Forms.TextBox();
            this.CLAVE_ADMIN = new System.Windows.Forms.TextBox();
            this.ClaveAdmin = new System.Windows.Forms.Label();
            this.CrearLocal = new System.Windows.Forms.Button();
            this.VerLocal = new System.Windows.Forms.Button();
            this.CrearLocales = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nombrelocal = new System.Windows.Forms.Label();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.label_Delivery = new System.Windows.Forms.Label();
            this.textBox_NombreLocal = new System.Windows.Forms.TextBox();
            this.textBox_DireccionLocal = new System.Windows.Forms.TextBox();
            this.DeliverySi = new System.Windows.Forms.RadioButton();
            this.DeliveryNo = new System.Windows.Forms.RadioButton();
            this.CreandoLocal = new System.Windows.Forms.Button();
            this.Ingresar_boton = new System.Windows.Forms.Button();
            this.BorrarLocal_Boton = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.ShowLocals = new System.Windows.Forms.ListBox();
            this.admin_local = new System.Windows.Forms.Button();
            this.ShowProducts = new System.Windows.Forms.ListBox();
            this.modificar_producto = new System.Windows.Forms.Button();
            this.agregar_p = new System.Windows.Forms.Button();
            this.volverProductos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nombre_producto = new System.Windows.Forms.Label();
            this.stock_product = new System.Windows.Forms.Label();
            this.price_product = new System.Windows.Forms.Label();
            this.changename_product = new System.Windows.Forms.TextBox();
            this.changestock_product = new System.Windows.Forms.TextBox();
            this.changeprecio_product = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LOGOFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // asAdmin
            // 
            this.asAdmin.AutoSize = true;
            this.asAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.asAdmin.Font = new System.Drawing.Font("Gabriola", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.asAdmin.Location = new System.Drawing.Point(44, 61);
            this.asAdmin.Name = "asAdmin";
            this.asAdmin.Size = new System.Drawing.Size(114, 50);
            this.asAdmin.TabIndex = 1;
            this.asAdmin.Text = "As Admin";
            this.asAdmin.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Rut_AdminVerificar
            // 
            this.Rut_AdminVerificar.AutoSize = true;
            this.Rut_AdminVerificar.BackColor = System.Drawing.Color.Transparent;
            this.Rut_AdminVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rut_AdminVerificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rut_AdminVerificar.Location = new System.Drawing.Point(22, 228);
            this.Rut_AdminVerificar.Name = "Rut_AdminVerificar";
            this.Rut_AdminVerificar.Size = new System.Drawing.Size(175, 25);
            this.Rut_AdminVerificar.TabIndex = 2;
            this.Rut_AdminVerificar.Text = "Ingrese su RUT";
            // 
            // RUT_ADMIN
            // 
            this.RUT_ADMIN.Location = new System.Drawing.Point(221, 232);
            this.RUT_ADMIN.Name = "RUT_ADMIN";
            this.RUT_ADMIN.Size = new System.Drawing.Size(203, 20);
            this.RUT_ADMIN.TabIndex = 3;
            this.RUT_ADMIN.TextChanged += new System.EventHandler(this.RUT_ADMIN_TextChanged);
            this.RUT_ADMIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RutAdmin_Enter);
            // 
            // CLAVE_ADMIN
            // 
            this.CLAVE_ADMIN.Enabled = false;
            this.CLAVE_ADMIN.Location = new System.Drawing.Point(221, 276);
            this.CLAVE_ADMIN.Name = "CLAVE_ADMIN";
            this.CLAVE_ADMIN.Size = new System.Drawing.Size(203, 20);
            this.CLAVE_ADMIN.TabIndex = 4;
            this.CLAVE_ADMIN.TextChanged += new System.EventHandler(this.CLAVE_ADMIN_TextChanged);
            this.CLAVE_ADMIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_Enter);
            // 
            // ClaveAdmin
            // 
            this.ClaveAdmin.AutoSize = true;
            this.ClaveAdmin.BackColor = System.Drawing.Color.Transparent;
            this.ClaveAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClaveAdmin.Location = new System.Drawing.Point(22, 276);
            this.ClaveAdmin.Name = "ClaveAdmin";
            this.ClaveAdmin.Size = new System.Drawing.Size(185, 25);
            this.ClaveAdmin.TabIndex = 5;
            this.ClaveAdmin.Text = "Ingrese su clave";
            // 
            // CrearLocal
            // 
            this.CrearLocal.Location = new System.Drawing.Point(38, 137);
            this.CrearLocal.Margin = new System.Windows.Forms.Padding(2);
            this.CrearLocal.Name = "CrearLocal";
            this.CrearLocal.Size = new System.Drawing.Size(159, 46);
            this.CrearLocal.TabIndex = 6;
            this.CrearLocal.Text = "Crear Local / Borrar Local";
            this.CrearLocal.UseVisualStyleBackColor = true;
            this.CrearLocal.Click += new System.EventHandler(this.CrearLocal_Click);
            // 
            // VerLocal
            // 
            this.VerLocal.Location = new System.Drawing.Point(221, 135);
            this.VerLocal.Margin = new System.Windows.Forms.Padding(2);
            this.VerLocal.Name = "VerLocal";
            this.VerLocal.Size = new System.Drawing.Size(150, 46);
            this.VerLocal.TabIndex = 7;
            this.VerLocal.Text = "Ver Local";
            this.VerLocal.UseVisualStyleBackColor = true;
            this.VerLocal.Click += new System.EventHandler(this.VerLocal_Click);
            // 
            // CrearLocales
            // 
            this.CrearLocales.FormattingEnabled = true;
            this.CrearLocales.Location = new System.Drawing.Point(623, 205);
            this.CrearLocales.Margin = new System.Windows.Forms.Padding(2);
            this.CrearLocales.Name = "CrearLocales";
            this.CrearLocales.Size = new System.Drawing.Size(285, 238);
            this.CrearLocales.TabIndex = 8;
            this.CrearLocales.SelectedIndexChanged += new System.EventHandler(this.CrearLocales_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_nombrelocal
            // 
            this.label_nombrelocal.AutoSize = true;
            this.label_nombrelocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombrelocal.Location = new System.Drawing.Point(456, 32);
            this.label_nombrelocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombrelocal.Name = "label_nombrelocal";
            this.label_nombrelocal.Size = new System.Drawing.Size(187, 20);
            this.label_nombrelocal.TabIndex = 11;
            this.label_nombrelocal.Text = "Ingrese Nombre de Local";
            this.label_nombrelocal.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Direccion.Location = new System.Drawing.Point(456, 73);
            this.label_Direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(175, 20);
            this.label_Direccion.TabIndex = 12;
            this.label_Direccion.Text = "Ingrese Direccion Local";
            // 
            // label_Delivery
            // 
            this.label_Delivery.AutoSize = true;
            this.label_Delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delivery.Location = new System.Drawing.Point(468, 104);
            this.label_Delivery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Delivery.Name = "label_Delivery";
            this.label_Delivery.Size = new System.Drawing.Size(126, 20);
            this.label_Delivery.TabIndex = 13;
            this.label_Delivery.Text = "Ingrese Delivery ";
            this.label_Delivery.Click += new System.EventHandler(this.label_Delivery_Click);
            // 
            // textBox_NombreLocal
            // 
            this.textBox_NombreLocal.Location = new System.Drawing.Point(692, 32);
            this.textBox_NombreLocal.Name = "textBox_NombreLocal";
            this.textBox_NombreLocal.Size = new System.Drawing.Size(200, 20);
            this.textBox_NombreLocal.TabIndex = 14;
            this.textBox_NombreLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NombreLocal_Enter);
            // 
            // textBox_DireccionLocal
            // 
            this.textBox_DireccionLocal.Location = new System.Drawing.Point(692, 73);
            this.textBox_DireccionLocal.Name = "textBox_DireccionLocal";
            this.textBox_DireccionLocal.Size = new System.Drawing.Size(200, 20);
            this.textBox_DireccionLocal.TabIndex = 15;
            this.textBox_DireccionLocal.TextChanged += new System.EventHandler(this.textBox_DireccionLocal_TextChanged);
            this.textBox_DireccionLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DireccionLocal_Enter);
            // 
            // DeliverySi
            // 
            this.DeliverySi.AutoSize = true;
            this.DeliverySi.Location = new System.Drawing.Point(706, 106);
            this.DeliverySi.Margin = new System.Windows.Forms.Padding(2);
            this.DeliverySi.Name = "DeliverySi";
            this.DeliverySi.Size = new System.Drawing.Size(37, 17);
            this.DeliverySi.TabIndex = 16;
            this.DeliverySi.TabStop = true;
            this.DeliverySi.Text = "Si ";
            this.DeliverySi.UseVisualStyleBackColor = true;
            this.DeliverySi.CheckedChanged += new System.EventHandler(this.DeliverySi_CheckedChanged);
            // 
            // DeliveryNo
            // 
            this.DeliveryNo.AutoSize = true;
            this.DeliveryNo.Location = new System.Drawing.Point(778, 107);
            this.DeliveryNo.Margin = new System.Windows.Forms.Padding(2);
            this.DeliveryNo.Name = "DeliveryNo";
            this.DeliveryNo.Size = new System.Drawing.Size(39, 17);
            this.DeliveryNo.TabIndex = 17;
            this.DeliveryNo.TabStop = true;
            this.DeliveryNo.Text = "No";
            this.DeliveryNo.UseVisualStyleBackColor = true;
            this.DeliveryNo.CheckedChanged += new System.EventHandler(this.DeliveryNo_CheckedChanged);
            // 
            // CreandoLocal
            // 
            this.CreandoLocal.Location = new System.Drawing.Point(623, 137);
            this.CreandoLocal.Margin = new System.Windows.Forms.Padding(2);
            this.CreandoLocal.Name = "CreandoLocal";
            this.CreandoLocal.Size = new System.Drawing.Size(80, 46);
            this.CreandoLocal.TabIndex = 18;
            this.CreandoLocal.Text = "Crear Local";
            this.CreandoLocal.UseVisualStyleBackColor = true;
            this.CreandoLocal.Click += new System.EventHandler(this.CreandoLocal_Click);
            // 
            // Ingresar_boton
            // 
            this.Ingresar_boton.Location = new System.Drawing.Point(241, 328);
            this.Ingresar_boton.Margin = new System.Windows.Forms.Padding(2);
            this.Ingresar_boton.Name = "Ingresar_boton";
            this.Ingresar_boton.Size = new System.Drawing.Size(137, 46);
            this.Ingresar_boton.TabIndex = 19;
            this.Ingresar_boton.Text = "Ingresar";
            this.Ingresar_boton.UseVisualStyleBackColor = true;
            this.Ingresar_boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrarLocal_Boton
            // 
            this.BorrarLocal_Boton.Location = new System.Drawing.Point(706, 137);
            this.BorrarLocal_Boton.Margin = new System.Windows.Forms.Padding(2);
            this.BorrarLocal_Boton.Name = "BorrarLocal_Boton";
            this.BorrarLocal_Boton.Size = new System.Drawing.Size(80, 46);
            this.BorrarLocal_Boton.TabIndex = 20;
            this.BorrarLocal_Boton.Text = "Borrar Local";
            this.BorrarLocal_Boton.UseVisualStyleBackColor = true;
            this.BorrarLocal_Boton.Click += new System.EventHandler(this.BorrarLocal_Boton_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(800, 137);
            this.volver.Margin = new System.Windows.Forms.Padding(2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(92, 46);
            this.volver.TabIndex = 21;
            this.volver.Text = "volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(394, 137);
            this.salir.Margin = new System.Windows.Forms.Padding(2);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(136, 46);
            this.salir.TabIndex = 22;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ShowLocals
            // 
            this.ShowLocals.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowLocals.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLocals.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ShowLocals.FormattingEnabled = true;
            this.ShowLocals.ItemHeight = 17;
            this.ShowLocals.Location = new System.Drawing.Point(98, 205);
            this.ShowLocals.Name = "ShowLocals";
            this.ShowLocals.Size = new System.Drawing.Size(326, 191);
            this.ShowLocals.TabIndex = 24;
            this.ShowLocals.SelectedIndexChanged += new System.EventHandler(this.ShowLocals_SelectedIndexChanged);
            // 
            // admin_local
            // 
            this.admin_local.BackColor = System.Drawing.Color.ForestGreen;
            this.admin_local.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_local.ForeColor = System.Drawing.Color.White;
            this.admin_local.Location = new System.Drawing.Point(98, 419);
            this.admin_local.Name = "admin_local";
            this.admin_local.Size = new System.Drawing.Size(326, 41);
            this.admin_local.TabIndex = 25;
            this.admin_local.Text = "Administrar Local";
            this.admin_local.UseVisualStyleBackColor = false;
            this.admin_local.Click += new System.EventHandler(this.admin_local_Click);
            // 
            // ShowProducts
            // 
            this.ShowProducts.BackColor = System.Drawing.Color.Wheat;
            this.ShowProducts.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowProducts.FormattingEnabled = true;
            this.ShowProducts.ItemHeight = 16;
            this.ShowProducts.Location = new System.Drawing.Point(213, 168);
            this.ShowProducts.Name = "ShowProducts";
            this.ShowProducts.Size = new System.Drawing.Size(451, 260);
            this.ShowProducts.TabIndex = 26;
            // 
            // modificar_producto
            // 
            this.modificar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modificar_producto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_producto.Location = new System.Drawing.Point(79, 489);
            this.modificar_producto.Name = "modificar_producto";
            this.modificar_producto.Size = new System.Drawing.Size(150, 57);
            this.modificar_producto.TabIndex = 27;
            this.modificar_producto.Text = "Modificar Producto";
            this.modificar_producto.UseVisualStyleBackColor = false;
            this.modificar_producto.Click += new System.EventHandler(this.modificar_producto_Click);
            // 
            // agregar_p
            // 
            this.agregar_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.agregar_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_p.Location = new System.Drawing.Point(241, 489);
            this.agregar_p.Name = "agregar_p";
            this.agregar_p.Size = new System.Drawing.Size(150, 57);
            this.agregar_p.TabIndex = 28;
            this.agregar_p.Text = "Agregar/Quitar Producto";
            this.agregar_p.UseVisualStyleBackColor = false;
            // 
            // volverProductos
            // 
            this.volverProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.volverProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverProductos.Location = new System.Drawing.Point(397, 489);
            this.volverProductos.Name = "volverProductos";
            this.volverProductos.Size = new System.Drawing.Size(150, 57);
            this.volverProductos.TabIndex = 29;
            this.volverProductos.Text = "Volver";
            this.volverProductos.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.AutoSize = true;
            this.nombre_producto.Location = new System.Drawing.Point(371, 267);
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.Size = new System.Drawing.Size(44, 13);
            this.nombre_producto.TabIndex = 32;
            this.nombre_producto.Text = "Nombre";
            // 
            // stock_product
            // 
            this.stock_product.AutoSize = true;
            this.stock_product.Location = new System.Drawing.Point(371, 293);
            this.stock_product.Name = "stock_product";
            this.stock_product.Size = new System.Drawing.Size(35, 13);
            this.stock_product.TabIndex = 33;
            this.stock_product.Text = "Stock";
            this.stock_product.Click += new System.EventHandler(this.stock_product_Click);
            // 
            // price_product
            // 
            this.price_product.AutoSize = true;
            this.price_product.Location = new System.Drawing.Point(371, 315);
            this.price_product.Name = "price_product";
            this.price_product.Size = new System.Drawing.Size(37, 13);
            this.price_product.TabIndex = 34;
            this.price_product.Text = "Precio";
            // 
            // changename_product
            // 
            this.changename_product.Location = new System.Drawing.Point(426, 260);
            this.changename_product.Name = "changename_product";
            this.changename_product.Size = new System.Drawing.Size(100, 20);
            this.changename_product.TabIndex = 35;
            // 
            // changestock_product
            // 
            this.changestock_product.Location = new System.Drawing.Point(426, 286);
            this.changestock_product.Name = "changestock_product";
            this.changestock_product.Size = new System.Drawing.Size(100, 20);
            this.changestock_product.TabIndex = 36;
            // 
            // changeprecio_product
            // 
            this.changeprecio_product.Location = new System.Drawing.Point(426, 312);
            this.changeprecio_product.Name = "changeprecio_product";
            this.changeprecio_product.Size = new System.Drawing.Size(100, 20);
            this.changeprecio_product.TabIndex = 37;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Despensa1;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.changeprecio_product);
            this.Controls.Add(this.changestock_product);
            this.Controls.Add(this.changename_product);
            this.Controls.Add(this.price_product);
            this.Controls.Add(this.stock_product);
            this.Controls.Add(this.nombre_producto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volverProductos);
            this.Controls.Add(this.agregar_p);
            this.Controls.Add(this.modificar_producto);
            this.Controls.Add(this.ShowProducts);
            this.Controls.Add(this.admin_local);
            this.Controls.Add(this.ShowLocals);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.BorrarLocal_Boton);
            this.Controls.Add(this.Ingresar_boton);
            this.Controls.Add(this.CreandoLocal);
            this.Controls.Add(this.DeliveryNo);
            this.Controls.Add(this.DeliverySi);
            this.Controls.Add(this.textBox_DireccionLocal);
            this.Controls.Add(this.textBox_NombreLocal);
            this.Controls.Add(this.label_Delivery);
            this.Controls.Add(this.label_Direccion);
            this.Controls.Add(this.label_nombrelocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CrearLocales);
            this.Controls.Add(this.VerLocal);
            this.Controls.Add(this.CrearLocal);
            this.Controls.Add(this.ClaveAdmin);
            this.Controls.Add(this.CLAVE_ADMIN);
            this.Controls.Add(this.RUT_ADMIN);
            this.Controls.Add(this.asAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Rut_AdminVerificar);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label asAdmin;
        private System.Windows.Forms.Label Rut_AdminVerificar;
        private System.Windows.Forms.TextBox RUT_ADMIN;
        private System.Windows.Forms.TextBox CLAVE_ADMIN;
        private System.Windows.Forms.Label ClaveAdmin;
        private System.Windows.Forms.Button CrearLocal;
        private System.Windows.Forms.Button VerLocal;
        private System.Windows.Forms.ListBox CrearLocales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_nombrelocal;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.Label label_Delivery;
        private System.Windows.Forms.TextBox textBox_NombreLocal;
        private System.Windows.Forms.TextBox textBox_DireccionLocal;
        private System.Windows.Forms.RadioButton DeliverySi;
        private System.Windows.Forms.RadioButton DeliveryNo;
        private System.Windows.Forms.Button CreandoLocal;
        private System.Windows.Forms.Button Ingresar_boton;
        private System.Windows.Forms.Button BorrarLocal_Boton;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.ListBox ShowLocals;
        private System.Windows.Forms.Button admin_local;
        private System.Windows.Forms.ListBox ShowProducts;
        private System.Windows.Forms.Button modificar_producto;
        private System.Windows.Forms.Button agregar_p;
        private System.Windows.Forms.Button volverProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nombre_producto;
        private System.Windows.Forms.Label stock_product;
        private System.Windows.Forms.Label price_product;
        private System.Windows.Forms.TextBox changename_product;
        private System.Windows.Forms.TextBox changestock_product;
        private System.Windows.Forms.TextBox changeprecio_product;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LOGOFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 57);
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
            this.asAdmin.Location = new System.Drawing.Point(59, 75);
            this.asAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.asAdmin.Name = "asAdmin";
            this.asAdmin.Size = new System.Drawing.Size(142, 63);
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
            this.Rut_AdminVerificar.Location = new System.Drawing.Point(29, 281);
            this.Rut_AdminVerificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rut_AdminVerificar.Name = "Rut_AdminVerificar";
            this.Rut_AdminVerificar.Size = new System.Drawing.Size(219, 31);
            this.Rut_AdminVerificar.TabIndex = 2;
            this.Rut_AdminVerificar.Text = "Ingrese su RUT";
            // 
            // RUT_ADMIN
            // 
            this.RUT_ADMIN.Location = new System.Drawing.Point(295, 286);
            this.RUT_ADMIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RUT_ADMIN.Name = "RUT_ADMIN";
            this.RUT_ADMIN.Size = new System.Drawing.Size(269, 22);
            this.RUT_ADMIN.TabIndex = 3;
            this.RUT_ADMIN.TextChanged += new System.EventHandler(this.RUT_ADMIN_TextChanged);
            this.RUT_ADMIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RutAdmin_Enter);
            // 
            // CLAVE_ADMIN
            // 
            this.CLAVE_ADMIN.Enabled = false;
            this.CLAVE_ADMIN.Location = new System.Drawing.Point(295, 340);
            this.CLAVE_ADMIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CLAVE_ADMIN.Name = "CLAVE_ADMIN";
            this.CLAVE_ADMIN.Size = new System.Drawing.Size(269, 22);
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
            this.ClaveAdmin.Location = new System.Drawing.Point(29, 340);
            this.ClaveAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClaveAdmin.Name = "ClaveAdmin";
            this.ClaveAdmin.Size = new System.Drawing.Size(228, 31);
            this.ClaveAdmin.TabIndex = 5;
            this.ClaveAdmin.Text = "Ingrese su clave";
            // 
            // CrearLocal
            // 
            this.CrearLocal.Location = new System.Drawing.Point(51, 169);
            this.CrearLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrearLocal.Name = "CrearLocal";
            this.CrearLocal.Size = new System.Drawing.Size(212, 57);
            this.CrearLocal.TabIndex = 6;
            this.CrearLocal.Text = "Crear Local / Borrar Local";
            this.CrearLocal.UseVisualStyleBackColor = true;
            this.CrearLocal.Click += new System.EventHandler(this.CrearLocal_Click);
            // 
            // VerLocal
            // 
            this.VerLocal.Location = new System.Drawing.Point(295, 166);
            this.VerLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VerLocal.Name = "VerLocal";
            this.VerLocal.Size = new System.Drawing.Size(200, 57);
            this.VerLocal.TabIndex = 7;
            this.VerLocal.Text = "Ver Local";
            this.VerLocal.UseVisualStyleBackColor = true;
            this.VerLocal.Click += new System.EventHandler(this.VerLocal_Click);
            // 
            // CrearLocales
            // 
            this.CrearLocales.FormattingEnabled = true;
            this.CrearLocales.ItemHeight = 16;
            this.CrearLocales.Location = new System.Drawing.Point(831, 252);
            this.CrearLocales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrearLocales.Name = "CrearLocales";
            this.CrearLocales.Size = new System.Drawing.Size(379, 292);
            this.CrearLocales.TabIndex = 8;
            this.CrearLocales.SelectedIndexChanged += new System.EventHandler(this.CrearLocales_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_nombrelocal
            // 
            this.label_nombrelocal.AutoSize = true;
            this.label_nombrelocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombrelocal.Location = new System.Drawing.Point(608, 39);
            this.label_nombrelocal.Name = "label_nombrelocal";
            this.label_nombrelocal.Size = new System.Drawing.Size(230, 25);
            this.label_nombrelocal.TabIndex = 11;
            this.label_nombrelocal.Text = "Ingrese Nombre de Local";
            this.label_nombrelocal.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Direccion.Location = new System.Drawing.Point(608, 90);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(215, 25);
            this.label_Direccion.TabIndex = 12;
            this.label_Direccion.Text = "Ingrese Direccion Local";
            // 
            // label_Delivery
            // 
            this.label_Delivery.AutoSize = true;
            this.label_Delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delivery.Location = new System.Drawing.Point(624, 128);
            this.label_Delivery.Name = "label_Delivery";
            this.label_Delivery.Size = new System.Drawing.Size(157, 25);
            this.label_Delivery.TabIndex = 13;
            this.label_Delivery.Text = "Ingrese Delivery ";
            this.label_Delivery.Click += new System.EventHandler(this.label_Delivery_Click);
            // 
            // textBox_NombreLocal
            // 
            this.textBox_NombreLocal.Location = new System.Drawing.Point(923, 39);
            this.textBox_NombreLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_NombreLocal.Name = "textBox_NombreLocal";
            this.textBox_NombreLocal.Size = new System.Drawing.Size(265, 22);
            this.textBox_NombreLocal.TabIndex = 14;
            this.textBox_NombreLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NombreLocal_Enter);
            // 
            // textBox_DireccionLocal
            // 
            this.textBox_DireccionLocal.Location = new System.Drawing.Point(923, 90);
            this.textBox_DireccionLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_DireccionLocal.Name = "textBox_DireccionLocal";
            this.textBox_DireccionLocal.Size = new System.Drawing.Size(265, 22);
            this.textBox_DireccionLocal.TabIndex = 15;
            this.textBox_DireccionLocal.TextChanged += new System.EventHandler(this.textBox_DireccionLocal_TextChanged);
            this.textBox_DireccionLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DireccionLocal_Enter);
            // 
            // DeliverySi
            // 
            this.DeliverySi.AutoSize = true;
            this.DeliverySi.Location = new System.Drawing.Point(941, 130);
            this.DeliverySi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeliverySi.Name = "DeliverySi";
            this.DeliverySi.Size = new System.Drawing.Size(45, 21);
            this.DeliverySi.TabIndex = 16;
            this.DeliverySi.TabStop = true;
            this.DeliverySi.Text = "Si ";
            this.DeliverySi.UseVisualStyleBackColor = true;
            this.DeliverySi.CheckedChanged += new System.EventHandler(this.DeliverySi_CheckedChanged);
            // 
            // DeliveryNo
            // 
            this.DeliveryNo.AutoSize = true;
            this.DeliveryNo.Location = new System.Drawing.Point(1037, 132);
            this.DeliveryNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeliveryNo.Name = "DeliveryNo";
            this.DeliveryNo.Size = new System.Drawing.Size(47, 21);
            this.DeliveryNo.TabIndex = 17;
            this.DeliveryNo.TabStop = true;
            this.DeliveryNo.Text = "No";
            this.DeliveryNo.UseVisualStyleBackColor = true;
            this.DeliveryNo.CheckedChanged += new System.EventHandler(this.DeliveryNo_CheckedChanged);
            // 
            // CreandoLocal
            // 
            this.CreandoLocal.Location = new System.Drawing.Point(831, 169);
            this.CreandoLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreandoLocal.Name = "CreandoLocal";
            this.CreandoLocal.Size = new System.Drawing.Size(107, 57);
            this.CreandoLocal.TabIndex = 18;
            this.CreandoLocal.Text = "Crear Local";
            this.CreandoLocal.UseVisualStyleBackColor = true;
            this.CreandoLocal.Click += new System.EventHandler(this.CreandoLocal_Click);
            // 
            // Ingresar_boton
            // 
            this.Ingresar_boton.Location = new System.Drawing.Point(321, 404);
            this.Ingresar_boton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ingresar_boton.Name = "Ingresar_boton";
            this.Ingresar_boton.Size = new System.Drawing.Size(183, 57);
            this.Ingresar_boton.TabIndex = 19;
            this.Ingresar_boton.Text = "Ingresar";
            this.Ingresar_boton.UseVisualStyleBackColor = true;
            this.Ingresar_boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrarLocal_Boton
            // 
            this.BorrarLocal_Boton.Location = new System.Drawing.Point(941, 169);
            this.BorrarLocal_Boton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorrarLocal_Boton.Name = "BorrarLocal_Boton";
            this.BorrarLocal_Boton.Size = new System.Drawing.Size(107, 57);
            this.BorrarLocal_Boton.TabIndex = 20;
            this.BorrarLocal_Boton.Text = "Borrar Local";
            this.BorrarLocal_Boton.UseVisualStyleBackColor = true;
            this.BorrarLocal_Boton.Click += new System.EventHandler(this.BorrarLocal_Boton_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(1067, 169);
            this.volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(123, 57);
            this.volver.TabIndex = 21;
            this.volver.Text = "volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(525, 169);
            this.salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(181, 57);
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
            this.ShowLocals.ItemHeight = 22;
            this.ShowLocals.Location = new System.Drawing.Point(131, 252);
            this.ShowLocals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowLocals.Name = "ShowLocals";
            this.ShowLocals.Size = new System.Drawing.Size(433, 224);
            this.ShowLocals.TabIndex = 24;
            this.ShowLocals.SelectedIndexChanged += new System.EventHandler(this.ShowLocals_SelectedIndexChanged);
            // 
            // admin_local
            // 
            this.admin_local.BackColor = System.Drawing.Color.ForestGreen;
            this.admin_local.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_local.ForeColor = System.Drawing.Color.White;
            this.admin_local.Location = new System.Drawing.Point(131, 516);
            this.admin_local.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin_local.Name = "admin_local";
            this.admin_local.Size = new System.Drawing.Size(435, 50);
            this.admin_local.TabIndex = 25;
            this.admin_local.Text = "Administrar Local";
            this.admin_local.UseVisualStyleBackColor = false;
            this.admin_local.Click += new System.EventHandler(this.admin_local_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Despensa1;
            this.ClientSize = new System.Drawing.Size(1224, 730);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}
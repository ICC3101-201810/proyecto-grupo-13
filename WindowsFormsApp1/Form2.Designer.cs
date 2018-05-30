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
            this.label2 = new System.Windows.Forms.Label();
            this.Ingresar_boton = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.admin_pedidos = new System.Windows.Forms.Button();
            this.nombre_admin = new System.Windows.Forms.Label();
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
            this.Rut_AdminVerificar.Location = new System.Drawing.Point(22, 233);
            this.Rut_AdminVerificar.Name = "Rut_AdminVerificar";
            this.Rut_AdminVerificar.Size = new System.Drawing.Size(175, 25);
            this.Rut_AdminVerificar.TabIndex = 2;
            this.Rut_AdminVerificar.Text = "Ingrese su RUT";
            // 
            // RUT_ADMIN
            // 
            this.RUT_ADMIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RUT_ADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUT_ADMIN.Location = new System.Drawing.Point(221, 232);
            this.RUT_ADMIN.Name = "RUT_ADMIN";
            this.RUT_ADMIN.Size = new System.Drawing.Size(226, 26);
            this.RUT_ADMIN.TabIndex = 3;
            this.RUT_ADMIN.TextChanged += new System.EventHandler(this.RUT_ADMIN_TextChanged);
            this.RUT_ADMIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RutAdmin_Enter);
            // 
            // CLAVE_ADMIN
            // 
            this.CLAVE_ADMIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CLAVE_ADMIN.Enabled = false;
            this.CLAVE_ADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLAVE_ADMIN.Location = new System.Drawing.Point(221, 276);
            this.CLAVE_ADMIN.Name = "CLAVE_ADMIN";
            this.CLAVE_ADMIN.Size = new System.Drawing.Size(226, 26);
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
            this.CrearLocal.BackColor = System.Drawing.Color.Turquoise;
            this.CrearLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearLocal.Location = new System.Drawing.Point(38, 137);
            this.CrearLocal.Margin = new System.Windows.Forms.Padding(2);
            this.CrearLocal.Name = "CrearLocal";
            this.CrearLocal.Size = new System.Drawing.Size(177, 46);
            this.CrearLocal.TabIndex = 6;
            this.CrearLocal.Text = "Manejo de Locales";
            this.CrearLocal.UseVisualStyleBackColor = false;
            this.CrearLocal.Click += new System.EventHandler(this.CrearLocal_Click);
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
            // Ingresar_boton
            // 
            this.Ingresar_boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ingresar_boton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar_boton.Location = new System.Drawing.Point(269, 323);
            this.Ingresar_boton.Margin = new System.Windows.Forms.Padding(2);
            this.Ingresar_boton.Name = "Ingresar_boton";
            this.Ingresar_boton.Size = new System.Drawing.Size(137, 46);
            this.Ingresar_boton.TabIndex = 19;
            this.Ingresar_boton.Text = "Ingresar";
            this.Ingresar_boton.UseVisualStyleBackColor = false;
            this.Ingresar_boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(446, 136);
            this.salir.Margin = new System.Windows.Forms.Padding(2);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(136, 46);
            this.salir.TabIndex = 22;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // admin_pedidos
            // 
            this.admin_pedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.admin_pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_pedidos.Location = new System.Drawing.Point(247, 137);
            this.admin_pedidos.Margin = new System.Windows.Forms.Padding(2);
            this.admin_pedidos.Name = "admin_pedidos";
            this.admin_pedidos.Size = new System.Drawing.Size(177, 46);
            this.admin_pedidos.TabIndex = 26;
            this.admin_pedidos.Text = "Administar Pedidos";
            this.admin_pedidos.UseVisualStyleBackColor = false;
            // 
            // nombre_admin
            // 
            this.nombre_admin.AutoSize = true;
            this.nombre_admin.BackColor = System.Drawing.Color.Transparent;
            this.nombre_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_admin.ForeColor = System.Drawing.Color.White;
            this.nombre_admin.Location = new System.Drawing.Point(264, 26);
            this.nombre_admin.Name = "nombre_admin";
            this.nombre_admin.Size = new System.Drawing.Size(85, 29);
            this.nombre_admin.TabIndex = 27;
            this.nombre_admin.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Despensa1;
            this.ClientSize = new System.Drawing.Size(950, 593);
            this.Controls.Add(this.nombre_admin);
            this.Controls.Add(this.admin_pedidos);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Ingresar_boton);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ingresar_boton;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button admin_pedidos;
        private System.Windows.Forms.Label nombre_admin;
    }
}
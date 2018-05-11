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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.asAdmin.Click += new System.EventHandler(this.label1_Click);
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
            this.CrearLocal.Location = new System.Drawing.Point(340, 169);
            this.CrearLocal.Name = "CrearLocal";
            this.CrearLocal.Size = new System.Drawing.Size(212, 56);
            this.CrearLocal.TabIndex = 6;
            this.CrearLocal.Text = "Crear Local";
            this.CrearLocal.UseVisualStyleBackColor = true;
            this.CrearLocal.Click += new System.EventHandler(this.CrearLocal_Click);
            // 
            // VerLocal
            // 
            this.VerLocal.Location = new System.Drawing.Point(570, 169);
            this.VerLocal.Name = "VerLocal";
            this.VerLocal.Size = new System.Drawing.Size(200, 56);
            this.VerLocal.TabIndex = 7;
            this.VerLocal.Text = "Ver Local";
            this.VerLocal.UseVisualStyleBackColor = true;
            // 
            // CrearLocales
            // 
            this.CrearLocales.FormattingEnabled = true;
            this.CrearLocales.ItemHeight = 16;
            this.CrearLocales.Location = new System.Drawing.Point(794, 232);
            this.CrearLocales.Name = "CrearLocales";
            this.CrearLocales.Size = new System.Drawing.Size(379, 292);
            this.CrearLocales.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Despensa1;
            this.ClientSize = new System.Drawing.Size(1224, 730);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
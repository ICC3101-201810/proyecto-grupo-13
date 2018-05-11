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
            this.asAdmin.Click += new System.EventHandler(this.label1_Click);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Despensa1;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.ClaveAdmin);
            this.Controls.Add(this.CLAVE_ADMIN);
            this.Controls.Add(this.RUT_ADMIN);
            this.Controls.Add(this.Rut_AdminVerificar);
            this.Controls.Add(this.asAdmin);
            this.Controls.Add(this.pictureBox1);
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
    }
}
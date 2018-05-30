namespace WindowsFormsApp1
{
    partial class Form6
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
            this.admin_local = new System.Windows.Forms.Button();
            this.BorrarLocal_Boton = new System.Windows.Forms.Button();
            this.CreandoLocal = new System.Windows.Forms.Button();
            this.DeliveryNo = new System.Windows.Forms.RadioButton();
            this.DeliverySi = new System.Windows.Forms.RadioButton();
            this.textBox_DireccionLocal = new System.Windows.Forms.TextBox();
            this.textBox_NombreLocal = new System.Windows.Forms.TextBox();
            this.label_Delivery = new System.Windows.Forms.Label();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.label_nombrelocal = new System.Windows.Forms.Label();
            this.CrearLocales = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_local
            // 
            this.admin_local.BackColor = System.Drawing.Color.ForestGreen;
            this.admin_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_local.ForeColor = System.Drawing.Color.White;
            this.admin_local.Location = new System.Drawing.Point(273, 462);
            this.admin_local.Name = "admin_local";
            this.admin_local.Size = new System.Drawing.Size(326, 41);
            this.admin_local.TabIndex = 37;
            this.admin_local.Text = "Administrar Local";
            this.admin_local.UseVisualStyleBackColor = false;
            this.admin_local.Click += new System.EventHandler(this.admin_local_Click);
            // 
            // BorrarLocal_Boton
            // 
            this.BorrarLocal_Boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BorrarLocal_Boton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarLocal_Boton.Location = new System.Drawing.Point(663, 231);
            this.BorrarLocal_Boton.Margin = new System.Windows.Forms.Padding(2);
            this.BorrarLocal_Boton.Name = "BorrarLocal_Boton";
            this.BorrarLocal_Boton.Size = new System.Drawing.Size(128, 46);
            this.BorrarLocal_Boton.TabIndex = 35;
            this.BorrarLocal_Boton.Text = "Borrar Local";
            this.BorrarLocal_Boton.UseVisualStyleBackColor = false;
            this.BorrarLocal_Boton.Click += new System.EventHandler(this.BorrarLocal_Boton_Click);
            // 
            // CreandoLocal
            // 
            this.CreandoLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CreandoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreandoLocal.Location = new System.Drawing.Point(663, 157);
            this.CreandoLocal.Margin = new System.Windows.Forms.Padding(2);
            this.CreandoLocal.Name = "CreandoLocal";
            this.CreandoLocal.Size = new System.Drawing.Size(128, 46);
            this.CreandoLocal.TabIndex = 34;
            this.CreandoLocal.Text = "Crear Local";
            this.CreandoLocal.UseVisualStyleBackColor = false;
            this.CreandoLocal.Click += new System.EventHandler(this.CreandoLocal_Click);
            // 
            // DeliveryNo
            // 
            this.DeliveryNo.AutoSize = true;
            this.DeliveryNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryNo.Location = new System.Drawing.Point(592, 112);
            this.DeliveryNo.Margin = new System.Windows.Forms.Padding(2);
            this.DeliveryNo.Name = "DeliveryNo";
            this.DeliveryNo.Size = new System.Drawing.Size(49, 24);
            this.DeliveryNo.TabIndex = 33;
            this.DeliveryNo.TabStop = true;
            this.DeliveryNo.Text = "No";
            this.DeliveryNo.UseVisualStyleBackColor = true;
            this.DeliveryNo.CheckedChanged += new System.EventHandler(this.DeliveryNo_CheckedChanged);
            // 
            // DeliverySi
            // 
            this.DeliverySi.AutoSize = true;
            this.DeliverySi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliverySi.Location = new System.Drawing.Point(484, 112);
            this.DeliverySi.Margin = new System.Windows.Forms.Padding(2);
            this.DeliverySi.Name = "DeliverySi";
            this.DeliverySi.Size = new System.Drawing.Size(48, 24);
            this.DeliverySi.TabIndex = 32;
            this.DeliverySi.TabStop = true;
            this.DeliverySi.Text = "Si ";
            this.DeliverySi.UseVisualStyleBackColor = true;
            this.DeliverySi.CheckedChanged += new System.EventHandler(this.DeliverySi_CheckedChanged);
            // 
            // textBox_DireccionLocal
            // 
            this.textBox_DireccionLocal.BackColor = System.Drawing.Color.Aquamarine;
            this.textBox_DireccionLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DireccionLocal.Location = new System.Drawing.Point(484, 67);
            this.textBox_DireccionLocal.Name = "textBox_DireccionLocal";
            this.textBox_DireccionLocal.Size = new System.Drawing.Size(200, 26);
            this.textBox_DireccionLocal.TabIndex = 31;
            this.textBox_DireccionLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.direccion_enter);
            // 
            // textBox_NombreLocal
            // 
            this.textBox_NombreLocal.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox_NombreLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NombreLocal.Location = new System.Drawing.Point(484, 22);
            this.textBox_NombreLocal.Name = "textBox_NombreLocal";
            this.textBox_NombreLocal.Size = new System.Drawing.Size(200, 26);
            this.textBox_NombreLocal.TabIndex = 30;
            this.textBox_NombreLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombrelocal_enter);
            // 
            // label_Delivery
            // 
            this.label_Delivery.AutoSize = true;
            this.label_Delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delivery.Location = new System.Drawing.Point(308, 112);
            this.label_Delivery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Delivery.Name = "label_Delivery";
            this.label_Delivery.Size = new System.Drawing.Size(126, 20);
            this.label_Delivery.TabIndex = 29;
            this.label_Delivery.Text = "Ingrese Delivery ";
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Direccion.Location = new System.Drawing.Point(269, 67);
            this.label_Direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(175, 20);
            this.label_Direccion.TabIndex = 28;
            this.label_Direccion.Text = "Ingrese Direccion Local";
            // 
            // label_nombrelocal
            // 
            this.label_nombrelocal.AutoSize = true;
            this.label_nombrelocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombrelocal.Location = new System.Drawing.Point(269, 20);
            this.label_nombrelocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombrelocal.Name = "label_nombrelocal";
            this.label_nombrelocal.Size = new System.Drawing.Size(187, 20);
            this.label_nombrelocal.TabIndex = 27;
            this.label_nombrelocal.Text = "Ingrese Nombre de Local";
            // 
            // CrearLocales
            // 
            this.CrearLocales.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CrearLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearLocales.ForeColor = System.Drawing.SystemColors.Menu;
            this.CrearLocales.FormattingEnabled = true;
            this.CrearLocales.ItemHeight = 20;
            this.CrearLocales.Location = new System.Drawing.Point(242, 157);
            this.CrearLocales.Margin = new System.Windows.Forms.Padding(2);
            this.CrearLocales.Name = "CrearLocales";
            this.CrearLocales.Size = new System.Drawing.Size(404, 264);
            this.CrearLocales.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LOGOFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(626, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.food_background;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin_local);
            this.Controls.Add(this.BorrarLocal_Boton);
            this.Controls.Add(this.CreandoLocal);
            this.Controls.Add(this.DeliveryNo);
            this.Controls.Add(this.DeliverySi);
            this.Controls.Add(this.textBox_DireccionLocal);
            this.Controls.Add(this.textBox_NombreLocal);
            this.Controls.Add(this.label_Delivery);
            this.Controls.Add(this.label_Direccion);
            this.Controls.Add(this.label_nombrelocal);
            this.Controls.Add(this.CrearLocales);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_local;
        private System.Windows.Forms.Button BorrarLocal_Boton;
        private System.Windows.Forms.Button CreandoLocal;
        private System.Windows.Forms.RadioButton DeliveryNo;
        private System.Windows.Forms.RadioButton DeliverySi;
        private System.Windows.Forms.TextBox textBox_DireccionLocal;
        private System.Windows.Forms.TextBox textBox_NombreLocal;
        private System.Windows.Forms.Label label_Delivery;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.Label label_nombrelocal;
        private System.Windows.Forms.ListBox CrearLocales;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
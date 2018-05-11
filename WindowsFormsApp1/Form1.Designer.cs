namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Registrarse = new System.Windows.Forms.Button();
            this.BOTONCLIENT = new System.Windows.Forms.Button();
            this.BOTONADMIN = new System.Windows.Forms.Button();
            this.LOGIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clienteRUT = new System.Windows.Forms.TextBox();
            this.clientenombre = new System.Windows.Forms.TextBox();
            this.verclave = new System.Windows.Forms.TextBox();
            this.ru1 = new System.Windows.Forms.Label();
            this.RUT = new System.Windows.Forms.Label();
            this.lmail = new System.Windows.Forms.Label();
            this.CLAVE12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CONFCLAVE = new System.Windows.Forms.Label();
            this.RUT1 = new System.Windows.Forms.TextBox();
            this.MAIL_textbox = new System.Windows.Forms.TextBox();
            this.nCuenta = new System.Windows.Forms.TextBox();
            this.clavecuenta = new System.Windows.Forms.TextBox();
            this.registro = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrarse
            // 
            this.Registrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarse.Location = new System.Drawing.Point(327, 348);
            this.Registrarse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(235, 65);
            this.Registrarse.TabIndex = 0;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // BOTONCLIENT
            // 
            this.BOTONCLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTONCLIENT.Location = new System.Drawing.Point(327, 282);
            this.BOTONCLIENT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BOTONCLIENT.Name = "BOTONCLIENT";
            this.BOTONCLIENT.Size = new System.Drawing.Size(235, 59);
            this.BOTONCLIENT.TabIndex = 2;
            this.BOTONCLIENT.Text = "CLIENTE";
            this.BOTONCLIENT.UseVisualStyleBackColor = true;
            this.BOTONCLIENT.Visible = false;
            this.BOTONCLIENT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BOTONADMIN
            // 
            this.BOTONADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTONADMIN.Location = new System.Drawing.Point(575, 282);
            this.BOTONADMIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BOTONADMIN.Name = "BOTONADMIN";
            this.BOTONADMIN.Size = new System.Drawing.Size(235, 59);
            this.BOTONADMIN.TabIndex = 3;
            this.BOTONADMIN.Text = "ADMINISTRADOR";
            this.BOTONADMIN.UseVisualStyleBackColor = true;
            this.BOTONADMIN.Visible = false;
            this.BOTONADMIN.Click += new System.EventHandler(this.BOTONADMIN_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(575, 348);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(240, 65);
            this.LOGIN.TabIndex = 4;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESEA REGISTRARSE COMO";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LOGOFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(8, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // clienteRUT
            // 
            this.clienteRUT.Location = new System.Drawing.Point(248, 444);
            this.clienteRUT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clienteRUT.Name = "clienteRUT";
            this.clienteRUT.Size = new System.Drawing.Size(0, 22);
            this.clienteRUT.TabIndex = 8;
            // 
            // clientenombre
            // 
            this.clientenombre.Location = new System.Drawing.Point(248, 476);
            this.clientenombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientenombre.Name = "clientenombre";
            this.clientenombre.Size = new System.Drawing.Size(363, 22);
            this.clientenombre.TabIndex = 9;
            this.clientenombre.Visible = false;
            this.clientenombre.TextChanged += new System.EventHandler(this.clientenombre_TextChanged);
            this.clientenombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Nombre);
            // 
            // verclave
            // 
            this.verclave.Location = new System.Drawing.Point(248, 577);
            this.verclave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.verclave.Name = "verclave";
            this.verclave.Size = new System.Drawing.Size(363, 22);
            this.verclave.TabIndex = 12;
            this.verclave.Visible = false;
            this.verclave.TextChanged += new System.EventHandler(this.verclave_TextChanged);
            this.verclave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clave_enter);
            // 
            // ru1
            // 
            this.ru1.AutoSize = true;
            this.ru1.BackColor = System.Drawing.Color.Transparent;
            this.ru1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ru1.Location = new System.Drawing.Point(53, 474);
            this.ru1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ru1.Name = "ru1";
            this.ru1.Size = new System.Drawing.Size(119, 29);
            this.ru1.TabIndex = 13;
            this.ru1.Text = "NOMBRE";
            this.ru1.Visible = false;
            this.ru1.Click += new System.EventHandler(this.ru1_Click);
            // 
            // RUT
            // 
            this.RUT.AutoSize = true;
            this.RUT.BackColor = System.Drawing.Color.Transparent;
            this.RUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUT.Location = new System.Drawing.Point(53, 503);
            this.RUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RUT.Name = "RUT";
            this.RUT.Size = new System.Drawing.Size(69, 29);
            this.RUT.TabIndex = 14;
            this.RUT.Text = "RUT ";
            this.RUT.Visible = false;
            // 
            // lmail
            // 
            this.lmail.AutoSize = true;
            this.lmail.BackColor = System.Drawing.Color.Transparent;
            this.lmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmail.Location = new System.Drawing.Point(53, 538);
            this.lmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(67, 29);
            this.lmail.TabIndex = 15;
            this.lmail.Text = "MAIL";
            this.lmail.Click += new System.EventHandler(this.lmail_Click);
            // 
            // CLAVE12
            // 
            this.CLAVE12.AutoSize = true;
            this.CLAVE12.BackColor = System.Drawing.Color.Transparent;
            this.CLAVE12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLAVE12.Location = new System.Drawing.Point(53, 571);
            this.CLAVE12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CLAVE12.Name = "CLAVE12";
            this.CLAVE12.Size = new System.Drawing.Size(89, 29);
            this.CLAVE12.TabIndex = 16;
            this.CLAVE12.Text = "CLAVE";
            this.CLAVE12.Click += new System.EventHandler(this.CLAVE12_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(248, 609);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmarClave);
            // 
            // CONFCLAVE
            // 
            this.CONFCLAVE.AutoSize = true;
            this.CONFCLAVE.BackColor = System.Drawing.Color.Transparent;
            this.CONFCLAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONFCLAVE.Location = new System.Drawing.Point(4, 609);
            this.CONFCLAVE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CONFCLAVE.Name = "CONFCLAVE";
            this.CONFCLAVE.Size = new System.Drawing.Size(223, 29);
            this.CONFCLAVE.TabIndex = 18;
            this.CONFCLAVE.Text = "CONFIRME CLAVE";
            // 
            // RUT1
            // 
            this.RUT1.Location = new System.Drawing.Point(248, 513);
            this.RUT1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RUT1.Name = "RUT1";
            this.RUT1.Size = new System.Drawing.Size(363, 22);
            this.RUT1.TabIndex = 19;
            this.RUT1.Visible = false;
            this.RUT1.TextChanged += new System.EventHandler(this.RUT1_TextChanged);
            this.RUT1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ENTER_RUT);
            // 
            // MAIL_textbox
            // 
            this.MAIL_textbox.Location = new System.Drawing.Point(248, 543);
            this.MAIL_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MAIL_textbox.Name = "MAIL_textbox";
            this.MAIL_textbox.Size = new System.Drawing.Size(363, 22);
            this.MAIL_textbox.TabIndex = 20;
            this.MAIL_textbox.Visible = false;
            this.MAIL_textbox.TextChanged += new System.EventHandler(this.MAIL_textbox_TextChanged);
            this.MAIL_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mail_Enter);
            // 
            // nCuenta
            // 
            this.nCuenta.Location = new System.Drawing.Point(347, 476);
            this.nCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nCuenta.Name = "nCuenta";
            this.nCuenta.Size = new System.Drawing.Size(363, 22);
            this.nCuenta.TabIndex = 21;
            this.nCuenta.Visible = false;
            this.nCuenta.TextChanged += new System.EventHandler(this.nCuenta_TextChanged);
            this.nCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ncuenta_Enter);
            // 
            // clavecuenta
            // 
            this.clavecuenta.Location = new System.Drawing.Point(347, 513);
            this.clavecuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clavecuenta.Name = "clavecuenta";
            this.clavecuenta.Size = new System.Drawing.Size(363, 22);
            this.clavecuenta.TabIndex = 22;
            this.clavecuenta.Visible = false;
            this.clavecuenta.TextChanged += new System.EventHandler(this.clavecuenta_TextChanged);
            this.clavecuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clavecuenta_KeyDown);
            // 
            // registro
            // 
            this.registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.ForeColor = System.Drawing.Color.Navy;
            this.registro.Location = new System.Drawing.Point(981, 577);
            this.registro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(200, 62);
            this.registro.TabIndex = 23;
            this.registro.Text = "Registrarse";
            this.registro.UseVisualStyleBackColor = false;
            this.registro.Visible = false;
            this.registro.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.Color.Navy;
            this.BACK.Location = new System.Drawing.Point(773, 577);
            this.BACK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(200, 62);
            this.BACK.TabIndex = 24;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Visible = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondo_1_poo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 730);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.RUT);
            this.Controls.Add(this.clavecuenta);
            this.Controls.Add(this.nCuenta);
            this.Controls.Add(this.MAIL_textbox);
            this.Controls.Add(this.RUT1);
            this.Controls.Add(this.CONFCLAVE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CLAVE12);
            this.Controls.Add(this.verclave);
            this.Controls.Add(this.clientenombre);
            this.Controls.Add(this.clienteRUT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.BOTONADMIN);
            this.Controls.Add(this.BOTONCLIENT);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.ru1);
            this.Controls.Add(this.lmail);
            this.Controls.Add(this.registro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Button BOTONCLIENT;
        private System.Windows.Forms.Button BOTONADMIN;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox clienteRUT;
        private System.Windows.Forms.TextBox clientenombre;
        private System.Windows.Forms.TextBox verclave;
        private System.Windows.Forms.Label ru1;
        private System.Windows.Forms.Label RUT;
        private System.Windows.Forms.Label lmail;
        private System.Windows.Forms.Label CLAVE12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CONFCLAVE;
        private System.Windows.Forms.TextBox RUT1;
        private System.Windows.Forms.TextBox MAIL_textbox;
        private System.Windows.Forms.TextBox nCuenta;
        private System.Windows.Forms.TextBox clavecuenta;
        private System.Windows.Forms.Button registro;
        private System.Windows.Forms.Button BACK;
    }
}


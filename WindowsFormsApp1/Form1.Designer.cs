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
            this.login_administrador = new System.Windows.Forms.Button();
            this.login_cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.back_bottom2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrarse
            // 
            this.Registrarse.BackColor = System.Drawing.SystemColors.Menu;
            this.Registrarse.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Foto_con_fondo_azul;
            this.Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registrarse.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarse.Location = new System.Drawing.Point(245, 283);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(176, 53);
            this.Registrarse.TabIndex = 0;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = false;
            this.Registrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // BOTONCLIENT
            // 
            this.BOTONCLIENT.BackColor = System.Drawing.SystemColors.Menu;
            this.BOTONCLIENT.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Foto_con_fondo_azul;
            this.BOTONCLIENT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BOTONCLIENT.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTONCLIENT.Location = new System.Drawing.Point(245, 229);
            this.BOTONCLIENT.Name = "BOTONCLIENT";
            this.BOTONCLIENT.Size = new System.Drawing.Size(176, 48);
            this.BOTONCLIENT.TabIndex = 2;
            this.BOTONCLIENT.Text = "Cliente";
            this.BOTONCLIENT.UseVisualStyleBackColor = false;
            this.BOTONCLIENT.Visible = false;
            this.BOTONCLIENT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BOTONADMIN
            // 
            this.BOTONADMIN.BackColor = System.Drawing.SystemColors.Menu;
            this.BOTONADMIN.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Foto_con_fondo_azul;
            this.BOTONADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BOTONADMIN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTONADMIN.Location = new System.Drawing.Point(431, 229);
            this.BOTONADMIN.Name = "BOTONADMIN";
            this.BOTONADMIN.Size = new System.Drawing.Size(219, 48);
            this.BOTONADMIN.TabIndex = 3;
            this.BOTONADMIN.Text = "Administrador";
            this.BOTONADMIN.UseVisualStyleBackColor = false;
            this.BOTONADMIN.Visible = false;
            this.BOTONADMIN.Click += new System.EventHandler(this.BOTONADMIN_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.SystemColors.Menu;
            this.LOGIN.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Foto_con_fondo_azul;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LOGIN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(431, 283);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(180, 53);
            this.LOGIN.TabIndex = 4;
            this.LOGIN.Text = "Login";
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desea registrarse como";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LOGOFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // clienteRUT
            // 
            this.clienteRUT.Location = new System.Drawing.Point(186, 361);
            this.clienteRUT.Name = "clienteRUT";
            this.clienteRUT.Size = new System.Drawing.Size(1, 20);
            this.clienteRUT.TabIndex = 8;
            // 
            // clientenombre
            // 
            this.clientenombre.Location = new System.Drawing.Point(377, 176);
            this.clientenombre.Name = "clientenombre";
            this.clientenombre.Size = new System.Drawing.Size(273, 20);
            this.clientenombre.TabIndex = 9;
            this.clientenombre.Visible = false;
            this.clientenombre.TextChanged += new System.EventHandler(this.clientenombre_TextChanged);
            this.clientenombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Nombre);
            // 
            // verclave
            // 
            this.verclave.Location = new System.Drawing.Point(377, 274);
            this.verclave.Name = "verclave";
            this.verclave.Size = new System.Drawing.Size(273, 20);
            this.verclave.TabIndex = 12;
            this.verclave.Visible = false;
            this.verclave.TextChanged += new System.EventHandler(this.verclave_TextChanged);
            this.verclave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clave_enter);
            // 
            // ru1
            // 
            this.ru1.AutoSize = true;
            this.ru1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ru1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ru1.Location = new System.Drawing.Point(242, 176);
            this.ru1.Name = "ru1";
            this.ru1.Size = new System.Drawing.Size(91, 22);
            this.ru1.TabIndex = 13;
            this.ru1.Text = "NOMBRE";
            this.ru1.Visible = false;
            this.ru1.Click += new System.EventHandler(this.ru1_Click);
            // 
            // RUT
            // 
            this.RUT.AutoSize = true;
            this.RUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RUT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RUT.Location = new System.Drawing.Point(242, 208);
            this.RUT.Name = "RUT";
            this.RUT.Size = new System.Drawing.Size(47, 22);
            this.RUT.TabIndex = 14;
            this.RUT.Text = "RUT ";
            this.RUT.Visible = false;
            this.RUT.Click += new System.EventHandler(this.RUT_Click);
            // 
            // lmail
            // 
            this.lmail.AutoSize = true;
            this.lmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmail.Location = new System.Drawing.Point(242, 242);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(56, 22);
            this.lmail.TabIndex = 15;
            this.lmail.Text = "MAIL";
            this.lmail.Click += new System.EventHandler(this.lmail_Click);
            // 
            // CLAVE12
            // 
            this.CLAVE12.AutoSize = true;
            this.CLAVE12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CLAVE12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLAVE12.Location = new System.Drawing.Point(241, 272);
            this.CLAVE12.Name = "CLAVE12";
            this.CLAVE12.Size = new System.Drawing.Size(74, 22);
            this.CLAVE12.TabIndex = 16;
            this.CLAVE12.Text = "CLAVE";
            this.CLAVE12.Click += new System.EventHandler(this.CLAVE12_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(377, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmarClave);
            // 
            // CONFCLAVE
            // 
            this.CONFCLAVE.AutoSize = true;
            this.CONFCLAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CONFCLAVE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONFCLAVE.Location = new System.Drawing.Point(171, 300);
            this.CONFCLAVE.Name = "CONFCLAVE";
            this.CONFCLAVE.Size = new System.Drawing.Size(174, 22);
            this.CONFCLAVE.TabIndex = 18;
            this.CONFCLAVE.Text = "CONFIRME CLAVE";
            // 
            // RUT1
            // 
            this.RUT1.Location = new System.Drawing.Point(377, 208);
            this.RUT1.Name = "RUT1";
            this.RUT1.Size = new System.Drawing.Size(273, 20);
            this.RUT1.TabIndex = 19;
            this.RUT1.Visible = false;
            this.RUT1.TextChanged += new System.EventHandler(this.RUT1_TextChanged);
            this.RUT1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ENTER_RUT);
            // 
            // MAIL_textbox
            // 
            this.MAIL_textbox.Location = new System.Drawing.Point(377, 246);
            this.MAIL_textbox.Name = "MAIL_textbox";
            this.MAIL_textbox.Size = new System.Drawing.Size(273, 20);
            this.MAIL_textbox.TabIndex = 20;
            this.MAIL_textbox.Visible = false;
            this.MAIL_textbox.TextChanged += new System.EventHandler(this.MAIL_textbox_TextChanged);
            this.MAIL_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mail_Enter);
            // 
            // nCuenta
            // 
            this.nCuenta.Location = new System.Drawing.Point(485, 176);
            this.nCuenta.Name = "nCuenta";
            this.nCuenta.Size = new System.Drawing.Size(273, 20);
            this.nCuenta.TabIndex = 21;
            this.nCuenta.Visible = false;
            this.nCuenta.TextChanged += new System.EventHandler(this.nCuenta_TextChanged);
            this.nCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ncuenta_Enter);
            // 
            // clavecuenta
            // 
            this.clavecuenta.Location = new System.Drawing.Point(485, 208);
            this.clavecuenta.Name = "clavecuenta";
            this.clavecuenta.Size = new System.Drawing.Size(273, 20);
            this.clavecuenta.TabIndex = 22;
            this.clavecuenta.Visible = false;
            this.clavecuenta.TextChanged += new System.EventHandler(this.clavecuenta_TextChanged);
            this.clavecuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clavecuenta_KeyDown);
            // 
            // registro
            // 
            this.registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.ForeColor = System.Drawing.Color.Black;
            this.registro.Location = new System.Drawing.Point(506, 343);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(150, 50);
            this.registro.TabIndex = 23;
            this.registro.Text = "Registrarse";
            this.registro.UseVisualStyleBackColor = false;
            this.registro.Visible = false;
            this.registro.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // login_administrador
            // 
            this.login_administrador.BackColor = System.Drawing.SystemColors.Menu;
            this.login_administrador.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Foto_con_fondo_azul;
            this.login_administrador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_administrador.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_administrador.ForeColor = System.Drawing.SystemColors.Desktop;
            this.login_administrador.Location = new System.Drawing.Point(431, 176);
            this.login_administrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_administrador.Name = "login_administrador";
            this.login_administrador.Size = new System.Drawing.Size(191, 48);
            this.login_administrador.TabIndex = 25;
            this.login_administrador.Text = "Administrador";
            this.login_administrador.UseVisualStyleBackColor = false;
            this.login_administrador.Click += new System.EventHandler(this.login_administrador_Click);
            // 
            // login_cliente
            // 
            this.login_cliente.BackColor = System.Drawing.SystemColors.Menu;
            this.login_cliente.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Foto_con_fondo_azul;
            this.login_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_cliente.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_cliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.login_cliente.Location = new System.Drawing.Point(244, 176);
            this.login_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_cliente.Name = "login_cliente";
            this.login_cliente.Size = new System.Drawing.Size(176, 48);
            this.login_cliente.TabIndex = 26;
            this.login_cliente.Text = "Cliente";
            this.login_cliente.UseVisualStyleBackColor = false;
            this.login_cliente.Click += new System.EventHandler(this.login_cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(240, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Desea ingresar como";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back1
            // 
            this.back1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back1.ForeColor = System.Drawing.Color.Black;
            this.back1.Location = new System.Drawing.Point(331, 342);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(155, 50);
            this.back1.TabIndex = 28;
            this.back1.Text = "BACK";
            this.back1.UseVisualStyleBackColor = false;
            this.back1.Click += new System.EventHandler(this.back1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(819, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 115);
            this.label3.TabIndex = 29;
            this.label3.Text = "?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.noinfo);
            this.label3.MouseHover += new System.EventHandler(this.info);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.Transparent;
            this.label_info.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_info.Location = new System.Drawing.Point(182, 98);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(704, 21);
            this.label_info.TabIndex = 30;
            this.label_info.Text = "Esta aplicacion te solucionara tus problemas a la hora de almuerzo, Registrarte o" +
    " Ingresa!";
            // 
            // back_bottom2
            // 
            this.back_bottom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back_bottom2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bottom2.ForeColor = System.Drawing.Color.Black;
            this.back_bottom2.Location = new System.Drawing.Point(331, 343);
            this.back_bottom2.Name = "back_bottom2";
            this.back_bottom2.Size = new System.Drawing.Size(155, 50);
            this.back_bottom2.TabIndex = 31;
            this.back_bottom2.Text = "BACK";
            this.back_bottom2.UseVisualStyleBackColor = false;
            this.back_bottom2.Click += new System.EventHandler(this.back_bottom2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Foto_con_fondo_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 617);
            this.Controls.Add(this.back_bottom2);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_cliente);
            this.Controls.Add(this.login_administrador);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button login_administrador;
        private System.Windows.Forms.Button login_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button back_bottom2;
    }
}


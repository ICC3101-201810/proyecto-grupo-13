namespace WindowsFormsApp1
{
    partial class CrearAdmin
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
            this.AdminNameBox = new System.Windows.Forms.Label();
            this.AdminRutBox = new System.Windows.Forms.Label();
            this.AdminMailBox = new System.Windows.Forms.Label();
            this.AdminPassBox = new System.Windows.Forms.Label();
            this.AdminPassVerifyBox = new System.Windows.Forms.Label();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.AdminRut = new System.Windows.Forms.TextBox();
            this.AdminMail = new System.Windows.Forms.TextBox();
            this.AdminPassword = new System.Windows.Forms.TextBox();
            this.AdminPassVerify = new System.Windows.Forms.TextBox();
            this.AdminRegisterButton = new System.Windows.Forms.Button();
            this.AdminBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminNameBox
            // 
            this.AdminNameBox.AutoSize = true;
            this.AdminNameBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminNameBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminNameBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminNameBox.Location = new System.Drawing.Point(357, 82);
            this.AdminNameBox.Name = "AdminNameBox";
            this.AdminNameBox.Size = new System.Drawing.Size(91, 22);
            this.AdminNameBox.TabIndex = 14;
            this.AdminNameBox.Text = "NOMBRE";
            this.AdminNameBox.Click += new System.EventHandler(this.AdminNameBox_Click);
            // 
            // AdminRutBox
            // 
            this.AdminRutBox.AutoSize = true;
            this.AdminRutBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminRutBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRutBox.ForeColor = System.Drawing.Color.Transparent;
            this.AdminRutBox.Location = new System.Drawing.Point(357, 203);
            this.AdminRutBox.Name = "AdminRutBox";
            this.AdminRutBox.Size = new System.Drawing.Size(47, 22);
            this.AdminRutBox.TabIndex = 15;
            this.AdminRutBox.Text = "RUT ";
            this.AdminRutBox.Click += new System.EventHandler(this.AdminRutBox_Click);
            // 
            // AdminMailBox
            // 
            this.AdminMailBox.AutoSize = true;
            this.AdminMailBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminMailBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMailBox.ForeColor = System.Drawing.Color.Transparent;
            this.AdminMailBox.Location = new System.Drawing.Point(357, 319);
            this.AdminMailBox.Name = "AdminMailBox";
            this.AdminMailBox.Size = new System.Drawing.Size(56, 22);
            this.AdminMailBox.TabIndex = 16;
            this.AdminMailBox.Text = "MAIL";
            this.AdminMailBox.Click += new System.EventHandler(this.AdminMailBox_Click);
            // 
            // AdminPassBox
            // 
            this.AdminPassBox.AutoSize = true;
            this.AdminPassBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminPassBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPassBox.ForeColor = System.Drawing.Color.Transparent;
            this.AdminPassBox.Location = new System.Drawing.Point(357, 440);
            this.AdminPassBox.Name = "AdminPassBox";
            this.AdminPassBox.Size = new System.Drawing.Size(74, 22);
            this.AdminPassBox.TabIndex = 17;
            this.AdminPassBox.Text = "CLAVE";
            this.AdminPassBox.Click += new System.EventHandler(this.AdminPasswordBox_Click);
            // 
            // AdminPassVerifyBox
            // 
            this.AdminPassVerifyBox.AutoSize = true;
            this.AdminPassVerifyBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminPassVerifyBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPassVerifyBox.ForeColor = System.Drawing.Color.Transparent;
            this.AdminPassVerifyBox.Location = new System.Drawing.Point(357, 462);
            this.AdminPassVerifyBox.Name = "AdminPassVerifyBox";
            this.AdminPassVerifyBox.Size = new System.Drawing.Size(174, 22);
            this.AdminPassVerifyBox.TabIndex = 19;
            this.AdminPassVerifyBox.Text = "CONFIRME CLAVE";
            this.AdminPassVerifyBox.Click += new System.EventHandler(this.AdminPassVerifyBox_Click);
            // 
            // AdminName
            // 
            this.AdminName.Location = new System.Drawing.Point(699, 82);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(195, 20);
            this.AdminName.TabIndex = 22;
            this.AdminName.TextChanged += new System.EventHandler(this.AddAdminName);
            this.AdminName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminCheckName);
            // 
            // AdminRut
            // 
            this.AdminRut.Location = new System.Drawing.Point(699, 207);
            this.AdminRut.Name = "AdminRut";
            this.AdminRut.Size = new System.Drawing.Size(195, 20);
            this.AdminRut.TabIndex = 23;
            this.AdminRut.TextChanged += new System.EventHandler(this.AddAdminRut);
            this.AdminRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminCheckRut);
            // 
            // AdminMail
            // 
            this.AdminMail.Location = new System.Drawing.Point(699, 319);
            this.AdminMail.Name = "AdminMail";
            this.AdminMail.Size = new System.Drawing.Size(195, 20);
            this.AdminMail.TabIndex = 24;
            this.AdminMail.TextChanged += new System.EventHandler(this.AddAdminMail);
            this.AdminMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminMailCheck);
            // 
            // AdminPassword
            // 
            this.AdminPassword.Location = new System.Drawing.Point(699, 440);
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.Size = new System.Drawing.Size(195, 20);
            this.AdminPassword.TabIndex = 25;
            this.AdminPassword.TextChanged += new System.EventHandler(this.AddAdminPassword);
            this.AdminPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminPassCheck);
            // 
            // AdminPassVerify
            // 
            this.AdminPassVerify.Location = new System.Drawing.Point(699, 462);
            this.AdminPassVerify.Name = "AdminPassVerify";
            this.AdminPassVerify.Size = new System.Drawing.Size(195, 20);
            this.AdminPassVerify.TabIndex = 26;
            this.AdminPassVerify.TextChanged += new System.EventHandler(this.AddAdminPassVerify);
            this.AdminPassVerify.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminFinalCheck);
            // 
            // AdminRegisterButton
            // 
            this.AdminRegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminRegisterButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRegisterButton.ForeColor = System.Drawing.Color.Black;
            this.AdminRegisterButton.Location = new System.Drawing.Point(720, 522);
            this.AdminRegisterButton.Name = "AdminRegisterButton";
            this.AdminRegisterButton.Size = new System.Drawing.Size(174, 46);
            this.AdminRegisterButton.TabIndex = 27;
            this.AdminRegisterButton.Text = "Registrarse";
            this.AdminRegisterButton.UseVisualStyleBackColor = false;
            this.AdminRegisterButton.Visible = false;
            this.AdminRegisterButton.Click += new System.EventHandler(this.AdminRegisterButton_Click);
            // 
            // AdminBackButton
            // 
            this.AdminBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AdminBackButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBackButton.ForeColor = System.Drawing.Color.Black;
            this.AdminBackButton.Location = new System.Drawing.Point(361, 518);
            this.AdminBackButton.Name = "AdminBackButton";
            this.AdminBackButton.Size = new System.Drawing.Size(155, 50);
            this.AdminBackButton.TabIndex = 32;
            this.AdminBackButton.Text = "BACK";
            this.AdminBackButton.UseVisualStyleBackColor = false;
            this.AdminBackButton.Click += new System.EventHandler(this.AdminBackButton_Click);
            // 
            // CrearAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._03;
            this.ClientSize = new System.Drawing.Size(1231, 709);
            this.Controls.Add(this.AdminBackButton);
            this.Controls.Add(this.AdminRegisterButton);
            this.Controls.Add(this.AdminPassVerify);
            this.Controls.Add(this.AdminPassword);
            this.Controls.Add(this.AdminMail);
            this.Controls.Add(this.AdminRut);
            this.Controls.Add(this.AdminName);
            this.Controls.Add(this.AdminPassVerifyBox);
            this.Controls.Add(this.AdminPassBox);
            this.Controls.Add(this.AdminMailBox);
            this.Controls.Add(this.AdminRutBox);
            this.Controls.Add(this.AdminNameBox);
            this.Name = "CrearAdmin";
            this.Text = "CrearAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminNameBox;
        private System.Windows.Forms.Label AdminRutBox;
        private System.Windows.Forms.Label AdminMailBox;
        private System.Windows.Forms.Label AdminPassBox;
        private System.Windows.Forms.Label AdminPassVerifyBox;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.TextBox AdminRut;
        private System.Windows.Forms.TextBox AdminMail;
        private System.Windows.Forms.TextBox AdminPassword;
        private System.Windows.Forms.TextBox AdminPassVerify;
        private System.Windows.Forms.Button AdminRegisterButton;
        private System.Windows.Forms.Button AdminBackButton;
    }
}
namespace WindowsFormsApp1
{
    partial class Form8
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
            this.Confirmar_Pedido = new System.Windows.Forms.CheckedListBox();
            this.cant_money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.formspay;
            this.pictureBox1.Location = new System.Drawing.Point(606, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Confirmar_Pedido
            // 
            this.Confirmar_Pedido.BackColor = System.Drawing.Color.Aquamarine;
            this.Confirmar_Pedido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar_Pedido.FormattingEnabled = true;
            this.Confirmar_Pedido.Location = new System.Drawing.Point(23, 150);
            this.Confirmar_Pedido.Name = "Confirmar_Pedido";
            this.Confirmar_Pedido.Size = new System.Drawing.Size(412, 364);
            this.Confirmar_Pedido.TabIndex = 6;
            this.Confirmar_Pedido.SelectedIndexChanged += new System.EventHandler(this.Confirmar_Pedido_SelectedIndexChanged);
            this.Confirmar_Pedido.SelectedValueChanged += new System.EventHandler(this.Conf_Pedido);
            // 
            // cant_money
            // 
            this.cant_money.AutoSize = true;
            this.cant_money.BackColor = System.Drawing.Color.Transparent;
            this.cant_money.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant_money.ForeColor = System.Drawing.SystemColors.Control;
            this.cant_money.Location = new System.Drawing.Point(20, 111);
            this.cant_money.Name = "cant_money";
            this.cant_money.Size = new System.Drawing.Size(28, 37);
            this.cant_money.TabIndex = 7;
            this.cant_money.Text = "$";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wallpaperjam_com_22422;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.cant_money);
            this.Controls.Add(this.Confirmar_Pedido);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox Confirmar_Pedido;
        private System.Windows.Forms.Label cant_money;
    }
}
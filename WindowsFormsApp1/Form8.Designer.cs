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
            this.cant_money = new System.Windows.Forms.Label();
            this.Comprar = new System.Windows.Forms.Button();
            this.Confirmar_Pedido = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frase = new System.Windows.Forms.Label();
            this.Nombre_Producto = new System.Windows.Forms.ListBox();
            this.paso = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cant_money
            // 
            this.cant_money.AutoSize = true;
            this.cant_money.BackColor = System.Drawing.Color.Transparent;
            this.cant_money.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant_money.ForeColor = System.Drawing.SystemColors.Control;
            this.cant_money.Location = new System.Drawing.Point(16, 255);
            this.cant_money.Name = "cant_money";
            this.cant_money.Size = new System.Drawing.Size(28, 37);
            this.cant_money.TabIndex = 7;
            this.cant_money.Text = "$";
            // 
            // Comprar
            // 
            this.Comprar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fundo_de_malha_de_gradiente_borrado_abstrato_1159_3172;
            this.Comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comprar.Location = new System.Drawing.Point(528, 369);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(366, 68);
            this.Comprar.TabIndex = 8;
            this.Comprar.Text = "Comprar";
            this.Comprar.UseVisualStyleBackColor = true;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // Confirmar_Pedido
            // 
            this.Confirmar_Pedido.BackColor = System.Drawing.Color.Aquamarine;
            this.Confirmar_Pedido.CheckOnClick = true;
            this.Confirmar_Pedido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar_Pedido.FormattingEnabled = true;
            this.Confirmar_Pedido.Location = new System.Drawing.Point(23, 296);
            this.Confirmar_Pedido.Name = "Confirmar_Pedido";
            this.Confirmar_Pedido.Size = new System.Drawing.Size(241, 200);
            this.Confirmar_Pedido.TabIndex = 6;
            this.Confirmar_Pedido.SelectedIndexChanged += new System.EventHandler(this.Conf_Pedido);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LOGOFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(11, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frase
            // 
            this.frase.AutoSize = true;
            this.frase.BackColor = System.Drawing.Color.Transparent;
            this.frase.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frase.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.frase.Location = new System.Drawing.Point(17, 208);
            this.frase.Name = "frase";
            this.frase.Size = new System.Drawing.Size(850, 51);
            this.frase.TabIndex = 10;
            this.frase.Text = "¡ Estas a solo un paso de disfrutar la mejor experiencia !";
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.BackColor = System.Drawing.Color.Khaki;
            this.Nombre_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Producto.FormattingEnabled = true;
            this.Nombre_Producto.ItemHeight = 20;
            this.Nombre_Producto.Location = new System.Drawing.Point(282, 292);
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.Size = new System.Drawing.Size(240, 204);
            this.Nombre_Producto.TabIndex = 11;
            // 
            // paso
            // 
            this.paso.AutoSize = true;
            this.paso.BackColor = System.Drawing.Color.Transparent;
            this.paso.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paso.Location = new System.Drawing.Point(18, 525);
            this.paso.Name = "paso";
            this.paso.Size = new System.Drawing.Size(278, 43);
            this.paso.TabIndex = 12;
            this.paso.Text = "Confirma tu Pedido! ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(528, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 33);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Escribe un Mensaje al Local";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wallpaperjam_com_22422;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.paso);
            this.Controls.Add(this.Nombre_Producto);
            this.Controls.Add(this.frase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.cant_money);
            this.Controls.Add(this.Confirmar_Pedido);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cant_money;
        private System.Windows.Forms.Button Comprar;
        private System.Windows.Forms.CheckedListBox Confirmar_Pedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label frase;
        private System.Windows.Forms.ListBox Nombre_Producto;
        private System.Windows.Forms.Label paso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
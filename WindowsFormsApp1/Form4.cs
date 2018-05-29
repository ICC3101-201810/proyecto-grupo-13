using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        Form2 parent;
        Local local;
        bool confirmar;
        public Form4(Form2 parent, Local local)
        {
            this.parent = parent;
            this.local = local;
            InitializeComponent();
            nombre_local.Text = "Local : " + " " + local.GetNameLocal();
            CreandoProductos.Visible = false;
            nameText.Visible = false;
            precio_text.Visible = false;
            stock_text.Visible = false;
            nombrep.Visible = false;
            Stockp.Visible = false;
            PrecioP.Visible = false;
            agregar_quitar.Enabled = true;
            foreach (Product products in local.GetMenu())
            {
                ListProducts.Items.Add(products.GetName() + " " + products.GetPrice() + " " + products.GetStock());
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }

        private void agregar_quitar_Click(object sender, EventArgs e)
        {
            nameText.Visible = true;
            nameText.Enabled = true;
            precio_text.Visible = true;
            stock_text.Visible = true;
            nombrep.Visible = true;
            precio_text.Enabled = false;
            stock_text.Enabled = false;
            Stockp.Visible = true;
            PrecioP.Visible = true;
            CreandoProductos.Visible = true;
            ListProducts.Visible = false;
            Modificar_p.Visible = false;
           
  
        }

        private void nombre_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nameText.Text != null)
                {
                    precio_text.Enabled = true;
                    confirmar = true;

                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre");
                }
            }
        }

        private void precio_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (precio_text.Text != null)
                {
                    stock_text.Enabled = true;
                    confirmar = true;

                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre");
                }
            }
        }

        private void stock_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (stock_text.Text != null)
                {
                    
                    confirmar = true;

                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Agregarfinal_Click(object sender, EventArgs e)
        {
            int Stock = Convert.ToInt32(stock_text.Text);
            int precio = Convert.ToInt32(precio_text.Text);
            CreandoProductos.Items.Add(nameText.Text);
            if (confirmar == true)
            {
                Product product = new Product(Stock, nameText.Text, precio);
                local.AddProduct(product);
                nameText.Text = "";
                precio_text.Text = "";
                stock_text.Text = "";
                
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

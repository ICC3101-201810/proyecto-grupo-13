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
        Form6 parent;
        Local localLogeado;
        bool confirmar;
        public Form4(Form6 parent, Local localLogeado)
        {
            this.parent = parent;
            this.localLogeado = localLogeado;
            InitializeComponent();
            label1.Text = "Local" + " " + localLogeado.GetNameLocal();
            foreach (Product products in localLogeado.menu)
            {
                ListProducts.Items.Add(products.GetName());
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
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
            ListProducts.Items.Add(nameText.Text);
            if (confirmar == true)
            {
                Product product = new Product(Stock, nameText.Text, precio);
                localLogeado.AddProduct(product);
                nameText.Text = "";
                precio_text.Text = "";
                stock_text.Text = "";
                
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void volver1_Click(object sender, EventArgs e)
        {
            
            Agregarfinal.Hide();
            eliminar_p.Hide();
            label1.Hide();
            nombre_local.Show();
            nameText.Hide();
            stock_text.Hide();
            precio_text.Hide();
            nombrep.Hide();
            Stockp.Hide();
            PrecioP.Hide();
            ListProducts.Show();
            Modificar_p.Show();
        }

        private void eliminar_p_Click(object sender, EventArgs e)
        {
            string guardarSelect = ListProducts.Items[ListProducts.SelectedIndex].ToString();
            int removeAt;
            removeAt = Convert.ToInt32(ListProducts.SelectedIndex);
            ListProducts.Items.RemoveAt(removeAt);
            for (int i = localLogeado.menu.Count - 1; i >= 0; i--)
            {
            if (guardarSelect == localLogeado.menu[i].GetName())
                {
                    localLogeado.menu.RemoveAt(i);
                    
                }
            }
            
        }
    }
}

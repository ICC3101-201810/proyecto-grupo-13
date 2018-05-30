﻿using System;
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
        Local local;
        Product productoSeleccionado = null;
        bool confirmar;
        public Form4(Form6 parent, Local local)
        {
            this.parent = parent;
            this.local = local;
            InitializeComponent();
            label1.Text = "Local" + " " + local.GetNameLocal();
            foreach (Product products in local.GetMenu())
            {
                ListProducts.Items.Add("Nombre"+ " " + products.GetName() + " " + "Precio :" +" " + products.GetPrice() + " "  + "Stock: " + " "+ products.GetStock());
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
            ListProducts.Items.Add("Nombre" + " " + nameText.Text + " " + "Precio :" + " " + precio + " " + "Stock: " + " " + Stock);
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
            for (int i = local.menu.Count - 1; i >= 0; i--)
            {

                if (guardarSelect == local.menu[i].GetName())
                {
                    local.menu.RemoveAt(i);
                }
            }
            
        }
    }
}

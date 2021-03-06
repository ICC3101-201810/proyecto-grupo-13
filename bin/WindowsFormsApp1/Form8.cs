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
    public partial class Form8 : Form
    {
        Form3 masterparent;
        Form7 parent;
        Product product;
        Local local;
        List<Product> carrito;
        Client client;

        public Form8(Form7 parent, Product product, Local local, List<Product> carrito, Client client, Form3 masterparent)
        {
            this.parent = parent;
            this.product = product;
            this.local = local;
            this.carrito = carrito;
            this.client = client;
            this.masterparent = masterparent;
            InitializeComponent();
            foreach (Product p in carrito)
            {
                Confirmar_Pedido.Items.Add(p.GetPrice());
                Nombre_Producto.Items.Add(p.GetName());

            }
        }

        int cant;
        bool efectivo;
        Product productoLogeado = null;
        List<Product> carro_final = new List<Product>();
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);

        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            if (cant > 0)
            {
                Form9 form9 = new Form9(this, cant , client, masterparent,local, carro_final, textBox1.Text);
                form9.Show();
                this.Hide();
            }
            
        }

        private void Conf_Pedido(object sender, EventArgs e)
        {
            if (Confirmar_Pedido.CheckOnClick == true)
            {
                
                if (Confirmar_Pedido.GetItemChecked(Confirmar_Pedido.SelectedIndex) == true)
                {
                    string money;
                    money = Convert.ToString(cant_money);
                    money = Confirmar_Pedido.Items[Confirmar_Pedido.SelectedIndex].ToString();
                    cant = cant + Convert.ToInt32(money);
                    cant_money.Text = "Total a pagar:" + " " + "$" + Convert.ToString(cant);
                    carro_final.Add(product); 
                    
                    //foreach(Product p in carrito)
                    //{
                      //  carro_final.Add(p);
                        
                        
                   // }

                }
                else
                {

                    //foreach (Product p in carrito)
                    //{
                    //  carro_final.Remove(p);
                    // }
                    carrito.Add(product);
                    string money;
                    money = Convert.ToString(cant_money);
                    money = Confirmar_Pedido.Items[Confirmar_Pedido.SelectedIndex].ToString();
                    cant = cant - Convert.ToInt32(money);
                    
                       
                        if (cant < 0)
                        {
                            cant = -cant;
                            cant_money.Text = "Total a pagar:" + " " + "$" + Convert.ToString(cant);
                             

                        }
                        else
                        {
                            cant_money.Text = "Total a pagar:" + " " + "$" + Convert.ToString(cant);
                           
                        }
                    
                    
                    
                    
                }
                
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagar_Efectivo pagar = new Pagar_Efectivo(this, client, masterparent, local, carro_final, textBox1.Text);
            pagar.Show();
            this.Hide();
        }
    }
}

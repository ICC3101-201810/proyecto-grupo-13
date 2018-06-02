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
    public partial class Form9 : Form
    {
        Form3 masterparent;
        Form8 parent;
        int pago;
        Client client;
        Local local;
        List<Product> carrito;
        string mensaje;
        public Form9(Form8 parent, int pago, Client client, Form3 masterparent,Local local, List<Product>carrito, string mensaje)
        {
            this.parent = parent;
            this.pago = pago;
            this.client = client;
            this.masterparent = masterparent;
            this.local = local;
            this.carrito = carrito;
            this.mensaje = mensaje;
            InitializeComponent();
            label3.Text = "Tu Saldo es" + " " + client.GetDinero().ToString();
            label2.Text = "Total a pagar" + "$" + pago.ToString();
            textBox2.Enabled = false;
           


        }
        Product productoLogeado = null;
        protected override void OnClosed(EventArgs e)
        {

            masterparent.Show();
            base.OnClosed(e);
        }
        bool confirmar;
        Pedido pedidoLog = null;
        private void enter_ncuenta(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Client c in UserManagment.clients)
                {
                    if (textBox1.Text == c.GetNdeCuenta())
                    {
                        textBox2.Enabled = true;
                        confirmar = true;
                    }
                    
                }
                
            }
        }

        private void clave_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Client c in UserManagment.clients)
                {
                    if (textBox2.Text == c.GetClaveCuenta())
                    {
                        confirmar = true;
                        if (c.GetDinero() > 0)
                        {
                          
                            c.DecreaseWallet(pago);
                        }
                        else
                        {
                            MessageBox.Show("No tienes saldo en tu cuenta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La clave es erronea");
                    }

                }
            }
        }

        private void pagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu Compra ha sido realizada con exito");

            label3.Text = "Tu Saldo es" + " " + client.GetDinero().ToString();
            for (int i =0 ; i<carrito.Count; i++)
            {
                productoLogeado = carrito[i];
                productoLogeado.DecreaseStock();
                Random random = new Random();
                int n_pedido = random.Next(0, 1500000);
                MessageBox.Show("Tu numero de pedido es" + " " +n_pedido.ToString());
                string codigo = n_pedido.ToString();
                Pedido pedido = new Pedido(client.GetName(), productoLogeado.GetName(), mensaje, local.GetDirection(), codigo);
                foreach (Local local_ in UserManagment.locales)
                {
                    if (local_.GetDirection() == local.GetDirection())
                    {
                        local_.pedidos.Add(pedido);
                    }
                }
            }   
               
            
            
        }   
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}

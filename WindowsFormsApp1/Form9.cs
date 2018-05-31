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
        public Form9(Form8 parent, int pago, Client client, Form3 masterparent,Local local, List<Product>carrito)
        {
            this.parent = parent;
            this.pago = pago;
            this.client = client;
            this.masterparent = masterparent;
            this.local = local;
            this.carrito = carrito;
            InitializeComponent();
            label3.Text = "Tu Saldo es" + " " + client.GetDinero().ToString();
            label2.Text = "Total a pagar" + "$" + pago.ToString();
            textBox2.Enabled = false;
           


        }
        protected override void OnClosed(EventArgs e)
        {

            masterparent.Show();
            base.OnClosed(e);
        }
        bool confirmar;
        int dinero_cliente; 
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
            
        }   
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

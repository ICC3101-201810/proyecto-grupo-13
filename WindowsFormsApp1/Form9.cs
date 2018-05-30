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
        Form8 parent;
        int pago;
        public Form9(Form8 parent, int pago)
        {
            this.parent = parent;
            this.pago = pago;
            // label2.Text = "A Pagar" + " "+ "$"+  Convert.ToString(pago);
            InitializeComponent();
            textBox2.Enabled = false;
        }
        Client client;
        bool confirmar;
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
                            int dinero_cliente;
                            dinero_cliente = c.GetDinero() - pago;
                            c.DecreaseWallet(dinero_cliente);
                            this.Hide();
                            
                            

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
    }
}

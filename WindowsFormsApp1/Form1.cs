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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Client c1 = new Client("Paz Torres", "cptorres@miuandes.cl", "paz45", 193226000, "pezdorado", "0210025", 500000);
            Admin a1 = new Admin("Matias Cabezas", "saima12@miuandes.cl", "weedlover", 192439396,null);
            UserManagment.CreateAdmin(a1);
            UserManagment.AddClient(c1);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BOTONCLIENT.Visible = Visible;
            BOTONADMIN.Visible = Visible;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BOTONADMIN.Visible = false;
            Registrarse.Visible = false;
        }

        private void BOTONADMIN_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {

        }

        private void ru1_Click(object sender, EventArgs e)
        {

        }

        private void MAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void RUT1_TextChanged(object sender, EventArgs e)
        {
            RUT1.MaxLength = 9;
        }

        private void ENTER_RUT(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]") && RUT1.TextLength < 8)
                {
                    MessageBox.Show("RUT NO VALIDO");
                }
                else
                {
                    if (UserManagment.ClientRutVerification(Convert.ToInt32(RUT1.Text)))
                    {
                        MessageBox.Show("Ya estas Registrado");
                    }
                    else
                    {
                        
                    }
                }

            }
        }

        private void clientenombre_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void MAIL_textbox_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void ConfirmarClave(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (verclave.Text == textBox1.Text)
                {
                    clientenombre.Visible = false;
                    MAIL_textbox.Visible = false;
                    verclave.Visible = false;
                    textBox1.Visible = false;
                    RUT1.Visible = false;

                }
                else
                {
                    MessageBox.Show("malo feo pesao");
                }
            }
        }

        private void verclave_TextChanged(object sender, EventArgs e)
        {
            verclave.PasswordChar = '*';
        }

        private void clave_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (verclave.TextLength < 4)
                {
                    MessageBox.Show("ingrese una clave mayor de cuatro digitos");
                }
                else
                {
                    textBox1.Enabled = true; 
                }
            }
        }
    }
}

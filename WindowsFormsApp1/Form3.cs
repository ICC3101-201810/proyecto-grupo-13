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
    public partial class Form3 : Form
    {
        Form1 parent;
        public Form3(Form1 parent) 
        {
            InitializeComponent();
            this.parent = parent;
            textBox2.Enabled = false;
            button1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
      
        Client clogeado = null;
        Client c;
        public bool verificar;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENTER1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rut;
                rut = Convert.ToInt32(textBox1.Text);
                c = UserManagment.ClientLoginRutVerification(rut);
                if (c != null)
                {
                    textBox2.Enabled = true;
                    verificar = true;
                }
                else
                {
                    MessageBox.Show("No valido");
                }
            }
        }

        private void Enter2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (verificar == true)
                {
                    string password;
                    password = textBox2.Text;
                    c = UserManagment.ClientLoginPassVerification(password);
                    if (c != null)
                    {
                        button1.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Clave no coincide");
                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clogeado = c;
            label3.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            string saldo= Convert.ToString(c.GetDinero());
            label4.Text = "Tu Saldo es  " + saldo;
            label3.Visible = true;
            textBox1.Hide();
            textBox2.Hide();

        }
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

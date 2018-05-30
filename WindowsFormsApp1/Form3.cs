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
            listLocals.Hide();
            verlocal.Hide();
            verlocal.Enabled = true;
        }

        Client clogeado = null;
        Client c;
        Local localSeleccionado = null;
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
            label4.Text = "Bievenido" + " " + clogeado.GetName();
            label3.Visible = true;
            textBox1.Hide();
            textBox2.Hide();
            listLocals.Show();
            verlocal.Show();
            foreach (Local local in UserManagment.locales)
            {
                listLocals.Items.Add(local.GetNameLocal());
                listLocals.Items.Add("-------------------------------");

            }

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

        private void listLocals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void verlocal_Click(object sender, EventArgs e)
        {
            string selectItem = listLocals.Items[listLocals.SelectedIndex].ToString();
            for (int i = UserManagment.locales.Count - 1; i >= 0; i--)
            {

                if (selectItem == UserManagment.locales[i].GetNameLocal())
                {
                    localSeleccionado = UserManagment.locales[i];
                    Form7 form7 = new Form7(this, localSeleccionado = UserManagment.locales[i], clogeado);
                    localSeleccionado.GetMenu();
                    form7.Show();
                    this.Hide();
                    
                }
                
            }
        }
    }
}

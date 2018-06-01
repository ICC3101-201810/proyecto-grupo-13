using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class CrearAdmin : Form
    {
        Form1 parent;
        public CrearAdmin(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            AdminRut.Enabled = false;
            AdminPassVerify.Enabled = false;
            AdminPassword.Enabled = false;
            AdminMail.Enabled = false;
        }
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }
        private void AddAdminName(object sender, EventArgs e)
        {
            AdminName.MaxLength = 25;
            
        }

        private void AddAdminRut(object sender, EventArgs e)
        {
            AdminRut.MaxLength = 9;
            
        }

        private void AddAdminMail(object sender, EventArgs e)
        {
            
            AdminMail.MaxLength = 15;
        }

        private void AddAdminPassword(object sender, EventArgs e)
        { 
            AdminPassword.MaxLength = 10;
            AdminPassword.PasswordChar = '*';
        }

        private void AddAdminPassVerify(object sender, EventArgs e)
        {

            AdminPassVerify.MaxLength = 10;
            AdminPassVerify.PasswordChar = '*';
        }

        private void AdminBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void AdminRegisterButton_Click(object sender, EventArgs e)
        {
            if (AdminName != null && AdminPassword != null)
            {
                int rut;
                rut = Convert.ToInt32(AdminRut.Text);
                Admin admin = new Admin(AdminName.Text, AdminMail.Text, AdminPassword.Text, rut, null);
                UserManagment.CreateAdmin(admin);
                MessageBox.Show("Has sido Registrado");
                this.Hide();
                parent.Show();
               

            }
        }

        private void AdminRutBox_Click(object sender, EventArgs e)
        {

        }

        private void AdminNameBox_Click(object sender, EventArgs e)
        {

        }

        private void AdminMailBox_Click(object sender, EventArgs e)
        {

        }

        private void AdminPassVerifyBox_Click(object sender, EventArgs e)
        {

        }

        private void AdminPasswordBox_Click(object sender, EventArgs e)
        {

        }

        private void AdminCheckName(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(AdminName.Text))
                {
                    MessageBox.Show("No puede estar este campo vacio");
                }
                else
                {
                    AdminRut.Enabled = true;
                }
            }
        }
        private void AdminCheckRut(object sender, KeyEventArgs e)
        {
            
           if (e.KeyCode == Keys.Enter)
           {
              if (!System.Text.RegularExpressions.Regex.IsMatch(AdminRut.Text, "[^0-9]") && AdminRut.TextLength < 8)
               {
                   MessageBox.Show("RUT NO VALIDO");
               }
               else
               {
                   if (UserManagment.ClientRutVerification(Convert.ToInt32(AdminRut.Text)))
                   {
                       MessageBox.Show("Ya estas Registrado");
                   }
                   else
                   {
                       AdminMail.Enabled = true;

                   }
               }

           }
        }

        private void AdminMailCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(AdminMail.Text))
                {
                    MessageBox.Show("No puede estar este campo vacio");
                }
                else
                {
                    AdminPassword.Enabled = true;
                }
            }
        }

        private void AdminPassCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(AdminPassword.Text))
                {
                    MessageBox.Show("No puede estar este campo vacio");
                }
                else if (AdminPassword.TextLength < 4)
                {
                    MessageBox.Show("ingrese una clave mayor de cuatro digitos");
                }
                else
                {
                    AdminPassVerify.Enabled = true;
                }
            }
        }

        private void AdminFinalCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AdminPassVerify.Text == AdminPassword.Text)
                {
                    AdminName.Visible = false;
                    AdminMail.Visible = false;
                    AdminPassword.Visible = false;
                    AdminPassVerify.Visible = false;
                    AdminRut.Visible = false;
                    AdminRegisterButton.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("Las claves no coiciden");
                }
            }
        }
    }
}

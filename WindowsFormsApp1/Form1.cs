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
    public partial class Form1 : Form
    {
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void Control_KeyUp2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        public Form1()
        {
            InitializeComponent();
            Client c1 = new Client("Paz Torres", "cptorres@miuandes.cl", "paz45", 193226000, "pezdorado", "0210025", 500000);
            Local l1 = new Local(false, null, "Las Condes 456", 0, "Subway", "LC1");
            Local l2 = new Local(true, null, "Uandes", 0, "Coffe Time", "LC2");
            Admin a1 = new Admin("Matias Cabezas", "mcabezas@miuandes.cl", "weedlover", 192439396, null);
            a1.AgregarLocal(l1);
            a1.AgregarLocal(l2);
            UserManagment.CreateAdmin(a1);
            UserManagment.AddClient(c1);
            UserManagment.CreateLocal(l1);
            UserManagment.CreateLocal(l2);
            Product p1 = new Product(45, "Sandwich BMT", 3000);
            Product p2 = new Product(500, "Capuccino Vainilla", 890);
            Product p3 = new Product(150, "Ice Tea", 900);
            l1.AddProduct(p1);
            l1.AddProduct(p3);
            l2.AddProduct(p2);
            String path = Directory.GetCurrentDirectory();
            ru1.Visible = false;
            RUT.Visible = false;
            CONFCLAVE.Visible = false;
            lmail.Visible = false;
            CLAVE12.Visible = false;
            RUT1.Enabled = false;
            MAIL_textbox.Enabled = false;
            verclave.Enabled = false;
            clavecuenta.Enabled = false;
            login_cliente.Visible = false;
            login_administrador.Visible = false;
            label1.Visible = false;
            back1.Visible = false;
            label_info.Visible = false;
            back_bottom2.Visible = false;
            button1_volver.Hide();
            UserManagment.Deserialize();

        }
        protected override void OnClosed(EventArgs e)
        {
            UserManagment.Serialize();
            base.OnClosed(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BOTONCLIENT.Visible = Visible;
            BOTONADMIN.Visible = Visible;
            LOGIN.Visible = false;
            Registrarse.Visible = false;
            label2.Visible = true;
            back1.Visible = Visible;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            BOTONADMIN.Visible = false;
            Registrarse.Visible = false;
            ru1.Visible = true;
            RUT.Visible = true;
            lmail.Visible = true;
            CLAVE12.Visible = true;
            CONFCLAVE.Visible = true;
            clientenombre.Visible = true;
            RUT1.Visible = Visible;
            verclave.Visible = true;
            textBox1.Visible = true;
            MAIL_textbox.Visible = true;
            BOTONCLIENT.Visible = false;
            label2.Visible = false;
            back1.Visible = false;
            back_bottom2.Visible = true;
            

        }
        private void BOTONADMIN_Click(object sender, EventArgs e) 
        {
            back1.Visible = false;

        }
        private void LOGIN_Click(object sender, EventArgs e)
        {
           
            login_cliente.Visible = true;
            login_administrador.Visible = true;
            label1.Visible = true;
            LOGIN.Visible = false;
            Registrarse.Visible = false;
            button1_volver.Show();



                 

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
                        MAIL_textbox.Enabled = true;
                      
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
                    ru1.Text = "Numero de Cuenta";
                    nCuenta.Visible = true;
                    RUT.Text = "ClaveCuentaBanco";
                    lmail.Visible = false;
                    CLAVE12.Visible = false;
                    CONFCLAVE.Visible = false;
                    clavecuenta.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("Las claves no coiciden");
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
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (nCuenta != null && clavecuenta!= null)
            {
                int rut;
                rut = Convert.ToInt32(RUT1.Text);
                int saldoDisp;
                Random random = new Random();
                saldoDisp = random.Next(5000, 150000);
                Client client = new Client(clientenombre.Text, MAIL_textbox.Text, verclave.Text, rut, clavecuenta.Text, nCuenta.Text, saldoDisp);
                UserManagment.AddClient(client);
                MessageBox.Show("Has sido Registrado");
                ru1.Visible = false;
                RUT.Visible = false;
                nCuenta.Visible = false;
                clavecuenta.Visible = false;
                BOTONCLIENT.Visible = false;
                Registrarse.Visible = true;
                LOGIN.Visible = true;
                ru1.Text = "Nombre";
                RUT.Text = "RUT";
                RUT1.Clear();
                clientenombre.Clear();
                MAIL_textbox.Clear();
                verclave.Clear();
                textBox1.Clear();
                nCuenta.Clear();
                clavecuenta.Clear();
                registro.Visible = false;
            }
            else
            {
                MessageBox.Show("No puedes dejar un campo vacio");
            }
        }

        private void lmail_Click(object sender, EventArgs e)
        {
        }
        private void Enter_Nombre(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (clientenombre.Text == null)
                {
                    MessageBox.Show("No Puede estar este campo vacío");
                    RUT1.Enabled = false;
                    lmail.Enabled = false;
                    verclave.Enabled = false;
                    CONFCLAVE.Enabled = false;
                }
                else
                {
                    RUT1.Enabled = true;
                }
            }
        }
        private void Mail_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MAIL_textbox.Text == null)
                {
                    MessageBox.Show("Ni puede estar este campo vacio");
                }
                else
                {
                    verclave.Enabled = true;
                }
            }
        }
        private void nCuenta_TextChanged(object sender, EventArgs e)
        {
            nCuenta.MaxLength = 12;
            

            

        }
        private void clavecuenta_TextChanged(object sender, EventArgs e)
        {
            clavecuenta.PasswordChar = '*';
        }
        private void BACK_Click(object sender, EventArgs e)
        {
            clientenombre.Visible = false;
            RUT1.Visible = false;
            MAIL_textbox.Visible = false;
            verclave.Visible = false;
            textBox1.Visible = false;
        }
        private void Ncuenta_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nCuenta.Text == null)
                {
                    MessageBox.Show("No puede estar este campo vacio");
                }
                else
                {
                   
                    clavecuenta.Enabled = true;
                }
            }
        }
        private void clavecuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nCuenta.Text == null)
                {
                    MessageBox.Show("No puede estar este campo vacio");
                }
                else
                {
                    registro.Visible = true;
                   
                }
            }
        }
        private void CLAVE12_Click(object sender, EventArgs e)
        {
        }

        private void login_administrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void login_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(this);
            f3.Show();


        }

        private void back1_Click(object sender, EventArgs e)
        {
            BOTONADMIN.Visible = false;
            BOTONCLIENT.Visible = false;
            Registrarse.Visible = true;
            LOGIN.Visible = true;
            back1.Visible = false;
            registro.Visible = false;

        }

        private void info(object sender, EventArgs e)
        {
            label_info.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void noinfo(object sender, EventArgs e)
        {
            label_info.Visible = false;
        }

        private void back_bottom2_Click(object sender, EventArgs e)
        {
            BOTONADMIN.Visible = true;
            Registrarse.Visible = true;
            ru1.Visible = false;
            RUT.Visible = false;
            lmail.Visible = false;
            RUT1.Visible = false;
            CLAVE12.Visible = false;
            CONFCLAVE.Visible = false;
            clavecuenta.Visible = false;
            clientenombre.Visible = false;
            clientenombre.Visible = false;
            RUT1.Visible = false;
            nCuenta.Visible = false;
            verclave.Visible = false;
            textBox1.Visible = false;
            MAIL_textbox.Visible = false;
            BOTONCLIENT.Visible = true;
            label2.Visible = true;
            back1.Visible = true;
            back_bottom2.Visible = false;
            Registrarse.Visible = false;
            registro.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RUT_Click(object sender, EventArgs e)
        {

        }

        private void button1_volver_Click(object sender, EventArgs e)
        {
            login_cliente.Hide();
            login_administrador.Hide();
            Registrarse.Show();
            LOGIN.Show();
            label1.Hide();
            button1_volver.Hide();
        }
    }
}

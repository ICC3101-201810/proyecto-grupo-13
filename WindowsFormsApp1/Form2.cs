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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CrearLocal.Hide();
            salir.Hide();
            nombre_admin.Hide();
           
        }
        public bool Verificar()
        {
            return true;
        }
        public Admin admin;
        Admin adminLogeado = null;
        public Local local1;
        //bool ver_local = true;
        //bool ver_local2 = true;
        


        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RUT_ADMIN_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void RutAdmin_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rut;
                rut = Convert.ToInt32(RUT_ADMIN.Text);
                RUT_ADMIN.MaxLength = 9; // MY NIGGA!!
                admin = UserManagment.AdminLoginRutVerification(rut);
                if (admin != null)
                {

                    Verificar();
                    CLAVE_ADMIN.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Este Rut no esta en nuestra base de datos");
                    
                }
            }
        }

        private void CLAVE_ADMIN_TextChanged(object sender, EventArgs e)
        {
            CLAVE_ADMIN.PasswordChar = '*';
        }

        private void Password_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Verificar() == true)
                {
                    string password;
                    password = CLAVE_ADMIN.Text;
                    admin = UserManagment.AdminLoginPassVerification(password);
                    if (admin!= null)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Clave mala");
                    }
                }
            }
        }
        
        private void CrearLocal_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this, adminLogeado);
            form6.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CrearLocales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NombreLocal_Enter(object sender, KeyEventArgs e)
        {
            
        }

        private void DireccionLocal_Enter(object sender, KeyEventArgs e)
        {
            
            
        }
        public bool confirmar { get; set; }
        private void DeliverySi_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void DeliveryNo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CreandoLocal_Click(object sender, EventArgs e)
        {
            
                //ShowLocals.Items.Add(local.GetNameLocal());
                
            
            
           
        }

        private void label_Delivery_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminLogeado = admin;
            CrearLocal.Visible = true;
            RUT_ADMIN.Visible = false;
            Rut_AdminVerificar.Visible = false;
            CLAVE_ADMIN.Visible = false;
            ClaveAdmin.Visible = false;
            Ingresar_boton.Visible = false;
            salir.Visible = true;
            nombre_admin.Show();
            nombre_admin.Text = "Bienvenido" + " " + adminLogeado.GetName();
        }

        private void textBox_DireccionLocal_TextChanged(object sender, EventArgs e)
        {
         
            
        }

        private void BorrarLocal_Boton_Click(object sender, EventArgs e)
        {
            
            

            

        }

        private void volver_Click(object sender, EventArgs e)
        {
           


        }

        private void salir_Click(object sender, EventArgs e)
        {
            RUT_ADMIN.Visible = true;
            Rut_AdminVerificar.Visible = true;
            CLAVE_ADMIN.Visible = true;
            ClaveAdmin.Visible = true;
            Ingresar_boton.Visible = true;
            salir.Visible = false;
            CrearLocal.Visible = false;
            RUT_ADMIN.Text = "";
            CLAVE_ADMIN.Text = "";
            nombre_admin.Hide();
        }

        private void ShowLocals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void VerLocal_Click(object sender, EventArgs e)
        {
            
        }

        private void admin_local_Click(object sender, EventArgs e)
        {
            
            
            
           
        }

        private void modificar_producto_Click(object sender, EventArgs e)
        {

        }

        private void stock_product_Click(object sender, EventArgs e)
        {

        }

        private void ShowProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admin_pedidos_Click(object sender, EventArgs e)
        {
            

        }
    }
}

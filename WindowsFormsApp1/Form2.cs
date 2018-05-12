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
            DeliverySi.Enabled = false;
            DeliveryNo.Enabled = false;
            CrearLocal.Visible = false;
            VerLocal.Visible = false;
            textBox_NombreLocal.Visible = false;
            label_nombrelocal.Visible = false;
            textBox_DireccionLocal.Visible = false;
            label_Direccion.Visible = false;
            label_Delivery.Visible = false;
            DeliverySi.Visible = false;
            DeliveryNo.Visible = false;
            CreandoLocal.Visible = false;
            BorrarLocal_Boton.Visible = false;
            CrearLocales.Visible = false;
            volver.Visible = false;
            salir.Visible = false;




            
            
        }
        public bool Verificar()
        {
            return true;
        }
        public Admin admin;
        Admin adminLogeado = null;
        

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
            CrearLocal.Visible = false;
            VerLocal.Visible = false;
            textBox_NombreLocal.Visible = true;
            label_nombrelocal.Visible = true;
            textBox_DireccionLocal.Visible = true;
            label_Direccion.Visible = true;
            label_Delivery.Visible = true;
            DeliverySi.Visible = true;
            DeliveryNo.Visible = true;
            CreandoLocal.Visible = true;
            BorrarLocal_Boton.Visible = true;
            CrearLocales.Visible = true;
            volver.Visible = true;
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
            if ( e.KeyCode == Keys.Enter)
            {
                if (textBox_NombreLocal.Text != null)
                {
                    textBox_DireccionLocal.Enabled = true;
                    confirmar = true;
                }
                else
                {
                    MessageBox.Show("Debes ingresar un Nombre");
                }
            }
        }

        private void DireccionLocal_Enter(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                if (textBox_DireccionLocal.Text != null)
                {
                    DeliverySi.Enabled = true;
                    DeliveryNo.Enabled = true;
                    
                }
            }
        }
        public bool confirmar { get; set; }
        private void DeliverySi_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmar== true)
            {
                CreandoLocal.Visible = true;
                confirmar = true;
            }
            

        }

        private void DeliveryNo_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmar == true)
            {
                CreandoLocal.Visible = true;
                confirmar = true;
            }
        }

        private void CreandoLocal_Click(object sender, EventArgs e)
        {
            CrearLocales.Items.Add(textBox_NombreLocal.Text);
            if (confirmar == true)
            {
                Local local = new Local(true, null, textBox_DireccionLocal.Text, 0, textBox_NombreLocal.Text, "0");
                UserManagment.CreateLocal(local);
                adminLogeado.AgregarLocal(local);
                MessageBox.Show("Tu local ha sido creado");
                textBox_NombreLocal.Text = "";
                textBox_DireccionLocal.Text = "";
                

            }
           
        }

        private void label_Delivery_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminLogeado = admin;
            CrearLocal.Visible = true;
            VerLocal.Visible = true;
            RUT_ADMIN.Visible = false;
            Rut_AdminVerificar.Visible = false;
            CLAVE_ADMIN.Visible = false;
            ClaveAdmin.Visible = false;
            Ingresar_boton.Visible = false;
            salir.Visible = true;
        }

        private void textBox_DireccionLocal_TextChanged(object sender, EventArgs e)
        {
         
            
        }

        private void BorrarLocal_Boton_Click(object sender, EventArgs e)
        {
            string  guardarSelect;
            guardarSelect = CrearLocales.SelectedIndex.ToString();
            int removeAt;
            removeAt = Convert.ToInt32(guardarSelect);
            CrearLocales.Items.RemoveAt(removeAt);
            // no se puede borrar de la base de datos 
            // UserMangment.RemoveLocal(Locales.Itemas...)
            // asi mismo no funciona con admin.
            

        }

        private void volver_Click(object sender, EventArgs e)
        {
            textBox_NombreLocal.Visible = false;
            label_nombrelocal.Visible = false;
            textBox_DireccionLocal.Visible = false;
            label_Direccion.Visible = false;
            label_Delivery.Visible = false;
            DeliveryNo.Visible = false;
            DeliverySi.Visible = false;
            CreandoLocal.Visible = false;
            BorrarLocal_Boton.Visible = false;
            CrearLocales.Visible = false;
            volver.Visible = false;
            CrearLocal.Visible = true;
            VerLocal.Visible = true;


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
            VerLocal.Visible = false;
            RUT_ADMIN.Text = "";
            CLAVE_ADMIN.Text = "";

        }
    }
}

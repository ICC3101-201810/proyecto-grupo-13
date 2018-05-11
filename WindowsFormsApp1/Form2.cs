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
        }

        private void label1_Click(object sender, EventArgs e)
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
                if (UserManagment.AdminLoginRutVerification(rut) != null)

                {
                    CLAVE_ADMIN.Enabled = true;


                }
                else
                {
                    MessageBox.Show("Este Rut no esta en nuestra base de datos");
                }
            }
        }
    }
}

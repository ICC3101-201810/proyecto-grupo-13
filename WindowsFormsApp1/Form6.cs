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
    public partial class Form6 : Form
    {
        Form2 parent;
        Admin adminLogeado;

        public Form6(Form2 parent, Admin adminLogeado)
        {
            this.parent = parent;
            this.adminLogeado = adminLogeado;
            InitializeComponent();
            foreach (Local local in adminLogeado.locales)
            {
                CrearLocales.Items.Add(local.GetNameLocal());
            }
            textBox_DireccionLocal.Enabled = false;
            DeliveryNo.Enabled = false;
            DeliverySi.Enabled = false;
        }
        bool confirmar;
        Local localSeleccionado = null;
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }

        private void nombrelocal_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

        private void direccion_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_DireccionLocal.Text != null)
                {
                    DeliverySi.Enabled = true;
                    DeliveryNo.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Debe ingresar una direccion");
                }
            }

        }
        private void DeliverySi_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmar == true)
            {
                confirmar = true;
            }
        }

        private void DeliveryNo_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmar == true)
            {

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

        private void BorrarLocal_Boton_Click(object sender, EventArgs e)
        {
            string guardarSelect = CrearLocales.Items[CrearLocales.SelectedIndex].ToString();
            int removeAt;
            removeAt = Convert.ToInt32(CrearLocales.SelectedIndex);
            CrearLocales.Items.RemoveAt(removeAt);
            for (int i = adminLogeado.locales.Count - 1; i >= 0; i--)
            {

                if (guardarSelect == adminLogeado.locales[i].GetNameLocal())
                {
                    adminLogeado.locales.RemoveAt(i);
                }
            }
            for (int j = UserManagment.locales.Count - 1; j >= 0; j--)
            {
                if (guardarSelect == UserManagment.locales[j].GetNameLocal())
                {
                    UserManagment.locales.RemoveAt(j);
                }
            }
        }

        private void admin_local_Click(object sender, EventArgs e)
        {
            string selectItem = CrearLocales.Items[CrearLocales.SelectedIndex].ToString();
            for (int i = adminLogeado.locales.Count - 1; i >= 0; i--)
            {

                if (selectItem == adminLogeado.locales[i].GetNameLocal())
                {

                    localSeleccionado = adminLogeado.locales[i];
                    Form4 form4 = new Form4(this, localSeleccionado = adminLogeado.locales[i]);
                    form4.Show();
                    this.Hide();
                    localSeleccionado.GetMenu();

                }
            }
        }
    }
}
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
    public partial class Form7 : Form
    {
        Form3 parent;
        Local local;
        Client client;
        Product productoLogeado = null;
        List<Product> carrito_client = new List<Product>();
        string contador;
        public Form7(Form3 parent,Local local,Client client, string contador)
        {
            this.parent = parent;
            this.local = local;
            this.client = client;
            this.contador = contador;
            InitializeComponent();
            label1.Text = "Local Ubicado en" + " " + local.GetDirection();
            label2.Text = "Delivery" + " " + local.GetDelivery();

            foreach (Product p in local.GetMenu())
            {
                productos.Items.Add(p.GetName());
                Stock_p.Items.Add(p.GetStock());
                Stock_p.Enabled = false;
                Precio_p.Enabled = false;
                Precio_p.Items.Add(p.GetPrice());
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }   
        private void selecc_p_Click(object sender, EventArgs e)
        {
            List<Product> menus = local.GetMenu();
            string selectItem = productos.Items[productos.SelectedIndex].ToString();
            
            for (int i = menus.Count - 1; i >= 0; i--)
            {
                productoLogeado = menus[i];
                if (selectItem == productoLogeado.GetName())
                {
                    int contador_final = Convert.ToInt32(contador);
                    contador_final++;
                    string c = Convert.ToString(contador_final);
                    p_acumulado.Text =c;
                    carrito_client.Add(productoLogeado);

                }
            }
        }

        private void carrrito_click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this,productoLogeado, local, carrito_client);
            form8.Show();
            this.Hide();
        }

        private void volver_locales_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
              
        }

        private void Info(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecciona el producto que desees comprar, una vez terminado tu pedido clickea el carrito para efectuar la compra" + MessageBoxIcon.Information);
        }

        private void p_acumulado_Click(object sender, EventArgs e)
        {

        }
    }
}

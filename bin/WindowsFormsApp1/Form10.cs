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
    public partial class Form10 : Form
    {
        Form6 parent;
        Admin a;
        Local local;
        // Form10 form10 = new Form10(this, admin|Logeado, local1);
        //form10.Show();
         // this.Hide(); poner en forms de locales :D 
        public Form10(Form6 parent, Admin a, Local local)
        {
            this.parent = parent;
            this.a = a;
            this.local = local;
            InitializeComponent();
            listBox1.Enabled = false;
            foreach (Pedido pedido in local.pedidos)
            {
                listBox1.Items.Add(pedido.GetName() + " "+  pedido.GetNameCliente()+ " " +  pedido.GetMensaje());
                listBox2.Items.Add(pedido.Getcodigo_identificador());
           
            }
        }
        Pedido pedLog = null;
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = listBox2.SelectedItem.ToString();
            for (int i = local.pedidos.Count - 1; i >= 0; i--)
            {
                pedLog = local.pedidos[i];
                if (select == pedLog.Getcodigo_identificador())
                {
                    local.pedidos.RemoveAt(i);
                    listBox2.Items.Add("Entregado");
                    listBox2.Items.RemoveAt(i);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string select = listBox2.SelectedItem.ToString();
            for (int i = local.pedidos.Count - 1; i >= 0; i--)
            {
                pedLog = local.pedidos[i];
                if (select == pedLog.Getcodigo_identificador())
                {
                    local.pedidos.RemoveAt(i);
                    listBox2.Items.Add("Anulado");
                    listBox2.Items.RemoveAt(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            for (int i = listBox2.Items.Count -1; i >= 0; i--)
            {
                if ( listBox2.Items.Contains("Entregado"))
                {
                    listBox1.Items.RemoveAt(i);
                    listBox2.Items.RemoveAt(i);
                }
                else if (listBox2.Items.Contains("Anulado"))
                {
                    listBox1.Items.RemoveAt(i);
                    listBox2.Items.RemoveAt(i);
                }
            }
               
           
        }
    }
}

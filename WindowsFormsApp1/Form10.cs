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
            foreach (Pedido pedido in local.pedidos)
            {
                listBox1.Items.Add(pedido.GetName() + pedido.GetNameCliente()+ pedido.GetMensaje());
                listBox2.Items.Add(pedido.Getcodigo_identificador());
           
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

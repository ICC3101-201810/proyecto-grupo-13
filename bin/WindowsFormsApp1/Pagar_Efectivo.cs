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
    
    public partial class Pagar_Efectivo : Form
    {
        Form8 parent;
        Client client;
        Form3 masterparent;
        Local local;
        List<Product> carro;
        string mensaje;
        public Pagar_Efectivo(Form8 parent,Client client,Form3 masterparent,Local local,List<Product>carro,string mensaje)
        {
            this.parent = parent;
            this.client = client;
            this.masterparent = masterparent;
            this.local = local;
            this.carro = carro;
            this.mensaje = mensaje;
            InitializeComponent();
            Product productoLogeado = null;
            for (int i = 0; i < carro.Count-1; i++)
            {
                productoLogeado = carro[i];
                productoLogeado.DecreaseStock();
                Random random = new Random();
                int n_pedido = random.Next(0, 1500000);
                MessageBox.Show("Tu numero de pedido es" + " " + n_pedido.ToString());
                string codigo = n_pedido.ToString();
                Pedido pedido = new Pedido(client.GetName(), productoLogeado.GetName(), mensaje, local.GetDirection(), codigo);
                foreach (Local local_ in UserManagment.locales)
                {
                    if (local_.GetDirection() == local.GetDirection())
                    {
                        local_.pedidos.Add(pedido);
                    }
                }
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            masterparent.Show();
            base.OnClosed(e);

        }
    }
}

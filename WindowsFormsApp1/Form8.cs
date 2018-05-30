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
    public partial class Form8 : Form
    {
        Form7 parent;
        Product product;
        Local local;
        List<Product> carrito;
        int cant;
        public Form8(Form7 parent, Product product, Local local, List<Product> carrito)
        {
            this.parent = parent;
            this.product = product;
            this.local = local;
            this.carrito = new List<Product>();
            InitializeComponent();
            foreach (Product p in carrito)
            {
                Confirmar_Pedido.Items.Add(p.GetName() + " " + "$"+ p.GetPrice());
               
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);

        }

        private void Confirmar_Pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
            
            
            
        }

        private void Conf_Pedido(object sender, EventArgs e)
        {
            int precio = product.GetPrice();
            cant = cant + precio;
            if (Confirmar_Pedido.CheckOnClick == false)
            {
                cant_money.Text = "A pagar" + " " + " " + "$" + Convert.ToString(cant);
            }
        }
    }
}

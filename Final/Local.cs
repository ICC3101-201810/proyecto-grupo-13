using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    public class Local
    {

        bool delivery;
        List<Product> menu;
        string direction;
        int accumulatedMoney;
        string name;
        string code;

        public Local(bool Delivery, List<Product> Menu, string Direccion, int DineroAcumulado, string Nombre, string Codigo)
        {
            this.delivery = Delivery;
            this.menu = new List<Product>();
            this.direction = Direccion;
            this.accumulatedMoney = DineroAcumulado;
            this.name = Nombre;
            this.code = Codigo;
        }
        public void AddProduct(Product product)
        {
            menu.Add(product);

        }
        public void ListProducts()
        {
            foreach (Product producto in menu)
            {
                Console.WriteLine(producto.GetName());
            }
        }
        public string GetNameLocal() { return this.name; }
        public string GetDirection() { return this.direction; }
        public string GetCodigo() { return this.code; }
        public List<Product> GetMenu()
        {
            return menu;
        }
        public bool GetDelivery()
        {
            return delivery;
        }
    }
}
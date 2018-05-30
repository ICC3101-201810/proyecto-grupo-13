using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    public class Local
    {
        bool delivery;
        public List<Product> menu;
        string direction;
        int accumulatedMoney;
        string name;
        string code;
        public Local(bool Delivery, List<Product> menu, string Direccion, int DineroAcumulado, string Nombre, string Codigo)
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
            int largeMenu = menu.Count;
            for (int i = 0; i < largeMenu; i++)
            {
                Product producto = menu[i];
                string productName = producto.GetName();
                int productPrice = producto.GetPrice();
                int stock = producto.GetStock();
                Console.WriteLine(String.Format("\t{0}. {1} - ${2} - Stock: {3}", i, productName, productPrice, stock));
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
        public int GetProductLenght()
        {
            int lenght = menu.Count;
            return lenght;
        }
    }
}
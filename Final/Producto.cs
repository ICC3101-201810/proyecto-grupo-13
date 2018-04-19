using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    public class Product
    {
        private int stock;
        string name;
        int price;

        public Product(int Stock, string Nombre, int Precio)
        {
            this.stock = Stock;
            this.name = Nombre;
            this.price = Precio;
        }
        public void DecreaseStock()
        {
            this.stock--;
        }
        public int GetStock() { return stock; }
        public string GetName() { return name; }
        public int GetPrice() { return price; }
    }
}

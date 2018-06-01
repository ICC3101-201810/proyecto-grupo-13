using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    [Serializable()]
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
        public int NewStock(int num)
        {
            this.stock = 0;
            this.stock += num;
            return stock;
        }
        public int NewPrice(int num)
        {
            this.price = 0;
            this.price += num;
            return price;
        }
    }
}

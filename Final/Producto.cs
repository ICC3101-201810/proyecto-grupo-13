using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    public class Producto
    {
        int Stock;
        string Nombre;
        int Precio;

        public Producto(int Stock, string Nombre, int Precio)
        {
            this.Stock = Stock;
            this.Nombre = Nombre;
            this.Precio = Precio;
        }
        public string GetName()
        {
            return this.Nombre;
        }
    }
}

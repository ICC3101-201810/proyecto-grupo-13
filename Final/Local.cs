using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    public class Local
    {

        bool Delivery;
        List<Producto> Menu;
        string Direccion;
        int DineroAcumulado;
        string Nombre;
        string Codigo;

        public Local(bool Delivery, List<Producto> Menu, string Direccion, int DineroAcumulado, string Nombre, string Codigo)
        {
            this.Delivery = Delivery;
            this.Menu = new List<Producto>();
            this.Direccion = Direccion;
            this.DineroAcumulado = DineroAcumulado;
            this.Nombre = Nombre;
            this.Codigo = Codigo;
        }
        public void AgregarProducto(Producto producto)
        {
            Menu.Add(producto);

        }
        public void DescribirProductos()
        {
            foreach (Producto p in Menu)
            {
                Console.WriteLine(p.GetName());
            }
        }
        public string GetNameLocal() { return this.Nombre; }
        public string GetDireccion() { return this.Direccion; }
        public string GetCodigo() { return this.Codigo; }

    }
}
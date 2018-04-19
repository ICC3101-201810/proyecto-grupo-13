using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Final
{
    class Compras
    {
        Local local;
        List<Producto> carrito = new List<Producto>();
        public Compras(Local local)
        {
            this.local = local;
        }
        public List<Producto> GetCarrito()
        {
            return carrito;
        }
        public void Agregar()
        {
            int input;
            Limpiar();
            List<Producto> menu = local.GetMenu();
            int LargoMenu = menu.Count;
            while (true)
            {
                Console.WriteLine("---> SELECCIONE UN PRODUCTO PARA AGREGAR O DEJAR EN BLANCO PARA SALIR <---");
                for (int i = 0; i < LargoMenu; i++)
                {
                    Producto producto = menu[i];
                    string NombreProducto = producto.GetNombre();
                    int PrecioProducto = producto.GetPrecio();
                    int Stock = producto.GetStock();
                    Console.WriteLine(String.Format("\t{0}. {1} - ${2} - Stock: {3}", i, NombreProducto, PrecioProducto, Stock));
                }
                List<Producto> carro = GetCarrito();
                Price(carro);
                Console.Write("=> Su respuesta: ");
                string linea = Console.ReadLine();
                if (linea == "")
                {
                    if (carrito.Count == 0)
                    {
                        Console.WriteLine("=> Debe seleccionar un elemento para proceder con su compra.");
                        Thread.Sleep(1000);
                        Limpiar();
                        continue;
                    }
                    Limpiar();
                    Procesando();
                    Thread.Sleep(100);
                    break;
                }
                input = int.Parse(linea);
                if (input >= LargoMenu || input < 0)
                {
                    Console.WriteLine("Opcion incorrecta, intente nuevamente");
                    Thread.Sleep(1000);
                    Limpiar();
                    continue;
                }
                else
                {
                    if (menu[input].GetStock() <= 0)
                    {
                        Console.WriteLine("No hay stock");
                        Thread.Sleep(1000);
                        Limpiar();
                        continue;
                    }
                    carrito.Add(menu[input]);
                    menu[input].disminuirStock();
                    Console.WriteLine("Producto agregado correctamente.");
                    Thread.Sleep(750);
                    Limpiar();
                }
            }
        }

        public void Limpiar()
        {
            Console.Clear();
            Console.WriteLine("\t\t ### Fast Food ###\n");
        }

        public bool VerificarDelivery()
        {
            string Linea;
            Limpiar();
            Console.WriteLine("Escriba (1) si desea entrega por delivery.");
            Console.WriteLine("Escriba (2) si desea retirar pedido en local: ");
            Linea = Console.ReadLine();
            int respuestaDelivery = int.Parse(Linea);
            Thread.Sleep(0500);
            Limpiar();

            while (respuestaDelivery != 2 && respuestaDelivery != 1)
            {
                Console.WriteLine("Opcion invalida.");
                Console.WriteLine("Escriba (1) si desea entrega por delivery.");
                Console.WriteLine("Escriba (2) si desea retirar pedido en local: ");
                Linea = Console.ReadLine();
                respuestaDelivery = int.Parse(Linea);
                Thread.Sleep(0250);
                Limpiar();
            }
            if (respuestaDelivery == 1) { return true; }
            else { return false; }
        }
        public void Price(List<Producto> carrito)
        {
            int price;
            int Sumatoria = 0;
            for (int i = 0; i < carrito.Count; i++)
            {
                Producto producto = carrito[i];
                price = producto.GetPrecio();
                Sumatoria += price;
            }
            Console.WriteLine("=> Precio actual de su compra: " + Sumatoria);

        }
        public void Procesando()
        {
            Limpiar();
            Console.Write("=> Procesando su compra");
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(600);
            Console.Write(":D");
        }
    }
}

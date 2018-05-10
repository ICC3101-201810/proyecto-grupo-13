using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WindowsFormsApp1
{
    public class Purchase
    {
        Local local;
        List<Product> shoppingCart = new List<Product>();
        public Purchase(Local local)
        {
            this.local = local;
        }
        public List<Product> GetShoppingCart()
        {
            return this.shoppingCart;
        }
        public void AddToCart()
        {
            int input;
            Cleaner();
            List<Product> menu = local.GetMenu();
            int largeMenu = menu.Count;
            while (true)
            {
                Console.WriteLine("---> SELECCIONE UN PRODUCTO PARA AGREGAR O DEJAR EN BLANCO PARA SALIR <---");
                for (int i = 0; i < largeMenu; i++)
                {
                    Product producto = menu[i];
                    string productName = producto.GetName();
                    int productPrice = producto.GetPrice();
                    int stock = producto.GetStock();
                    Console.WriteLine(String.Format("\t{0}. {1} - ${2} - Stock: {3}", i, productName, productPrice, stock));
                }
                List<Product> cart = GetShoppingCart();
                ShowFinalPrice(cart);
                Console.Write("=> Su respuesta: ");
                string linea = Console.ReadLine();
                if (linea == "")
                {
                    if (shoppingCart.Count == 0)
                    {
                        Console.WriteLine("=> Debe seleccionar un elemento para proceder con su compra.");
                        Thread.Sleep(1000);
                        Cleaner();
                        continue;
                    }
                    Cleaner();
                    Processing();
                    CheckPayPal();
                    Thread.Sleep(100);
                    break;
                }
                input = int.Parse(linea);
                if (input >= largeMenu || input < 0)
                {
                    Console.WriteLine("Opcion incorrecta, intente nuevamente");
                    Thread.Sleep(1000);
                    Cleaner();
                    continue;
                }
                else
                {
                    if (menu[input].GetStock() <= 0)
                    {
                        Console.WriteLine("No hay stock");
                        Thread.Sleep(1000);
                        Cleaner();
                        continue;
                    }
                    shoppingCart.Add(menu[input]);
                    menu[input].DecreaseStock();
                    Console.WriteLine("Producto agregado correctamente.");
                    Thread.Sleep(750);
                    Cleaner();
                }
            }
        }

        public void Cleaner()
        {
            Console.Clear();
            Console.WriteLine("\t\t ### Fast Food ###\n");
        }
        public bool CheckDelivery()
        {
            string Linea;
            Cleaner();
            Console.WriteLine("Escriba (1) si desea entrega por delivery.");
            Console.WriteLine("Escriba (2) si desea retirar pedido en local: ");
            Linea = Console.ReadLine();
            int respuestaDelivery = int.Parse(Linea);
            Thread.Sleep(0500);
            Cleaner();

            while (respuestaDelivery != 2 && respuestaDelivery != 1)
            {
                Console.WriteLine("Opcion invalida.");
                Console.WriteLine("Escriba (1) si desea entrega por delivery.");
                Console.WriteLine("Escriba (2) si desea retirar pedido en local: ");
                Linea = Console.ReadLine();
                respuestaDelivery = int.Parse(Linea);
                Thread.Sleep(0250);
                Cleaner();
            }
            if (respuestaDelivery == 1) { return true; }
            else { return false; }
        }
        public void ShowFinalPrice(List<Product> cart)
        {
            int price;
            int summation = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                Product product = cart[i];
                price = product.GetPrice();
                summation += price;
            }
            Console.WriteLine("=> Precio actual de su compra: " + summation );
        }
        public void Processing()
        {
            Cleaner();
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
        public bool CheckPayPal()
        {
            string Linea;
            Cleaner();
            Console.WriteLine("Escriba (1) si desea pago por tarjeta: ");
            Console.WriteLine("Escriba (2) si desea pago por efectivo: ");
            Linea = Console.ReadLine();
            int ansCPP = int.Parse(Linea);
            Thread.Sleep(0500);
            Cleaner();

            while (ansCPP != 2 && ansCPP != 1)
            {
                Console.WriteLine("Opcion invalida.");
                Console.WriteLine("Escriba (1) si desea pago por tarjeta: ");
                Console.WriteLine("Escriba (2) si desea pago por efectivo: ");
                Linea = Console.ReadLine();
                ansCPP = int.Parse(Linea);
                Thread.Sleep(0250);
                Cleaner();
            }
            if (ansCPP == 1) { return true; }
            else { return false; }
        }
        public int FinalPrice(List<Product> cart)
        {
            int price;
            int summation = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                Product product = cart[i];
                price = product.GetPrice();
                summation += price;
            }
            return summation;
        }
    }
}

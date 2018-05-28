using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{

    public static class UserManagment
    {
        static List<Client> clients = new List<Client>();
        static List<Admin> admins = new List<Admin>();
        static public List<Local> locales = new List<Local>();
        static public Bank bank;
        static public Admin admin;
        static public Client client;

        // agregar SAVE DATA 
        // Load DATA
        public static void Serialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("clients.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, clients);
            stream.Close();

        }
        public static void Deserialize()
        {
            if (File.Exists("clients.bin"))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("clients.bin", FileMode.Open, FileAccess.Read);
                clients = (List<Client>)formatter.Deserialize(stream);
                stream.Close();
            }
        }
        public static void AddClient(Client client)
        {
            clients.Add(client);
        } 
        public static  void CreateAdmin(Admin admin)
        {
            admins.Add(admin);

        }
        public static void CreateLocal(Local local)
        {
            locales.Add(local);
        }
        public static void RemoveLocal(Local local)
        {
            locales.Remove(local);
        }
        public static bool VerificationRut2(int Rut)
        {
            foreach (Admin admin in admins)
            {
                if (admin.GetRut() == Rut)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ClientRutVerification(int Rut)
        {
            foreach (Client c in clients)
            {
                if (c.GetRut() == Rut)
                {
                    return true;
                }
            }
            return false;
        }
        public static Client ClientLoginRutVerification(int rut)
        {
            foreach (Client c in clients)
            {
                if (c.GetRut() == rut)
                {
                    return c;
                }
            }
            return null;
        }
        public static Admin GetAdmin()
        {
            return admin;
        }
        public static  Client ClientLoginPassVerification(string password)
        {
            foreach (Client c in clients)
            {
                if (c.GetClave() == password)
                {
                    return c;
                }
            }
            return null;
        }
        public  static Admin AdminRutVerification(int rut)
        {
            foreach (Admin a in admins)
            {
                if (a.GetRut() == rut)
                {
                    return a;
                }
            }
            return null;
        }
        public  static Admin AdminLoginRutVerification(int rut) // para registrar
        {
            foreach (Admin a in admins)
            {
                if (a.GetRut() == rut)
                {
                    return a;
                }
            }
            return null;
        }
        public static Admin AdminLoginPassVerification(string password)
        {
            foreach (Admin a in admins)
            {
                if (a.GetClave() == password)
                {
                    return a;
                }
            }
            return null;
        }
        public  static void CreateUserInterface()
        {
            while (true)
            {
                
                Console.WriteLine(" => 1.Nuevo Cliente" + Environment.NewLine + " => 2.Nuevo Administrador de Locales" + Environment.NewLine + " => 3.Volver Atras");
                string option1;
                option1 = Convert.ToString(Console.ReadLine());
                if (option1 == "1")
                {
                    
                    Console.WriteLine(" => Ingrese su nombre: ");
                    string name;
                    name = Console.ReadLine();
                    
                    Console.WriteLine(" => Ingrese su Rut: ");
                    int rut;
                    rut = Convert.ToInt32(Console.ReadLine());

                    if (ClientRutVerification(rut))
                    {
                        Console.WriteLine(" => Este rut ya existe: ");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        
                        string mail;
                        Console.WriteLine(" => Ingrese su Mail: ");
                        mail = Console.ReadLine();
                        while (true)
                        {
                            
                            string password;
                            Console.WriteLine(" => Ingrese su Clave: ");
                            password = Console.ReadLine();
                            
                            Console.WriteLine(" => Compruebe su clave: ");
                            string password2;
                            password2 = Console.ReadLine();
                            if (password == password2)
                            {
                                
                                Console.WriteLine(" => Ingrese su Numero de Cuenta de Banco: ");
                                string num;
                                num = Convert.ToString(Console.ReadLine());
                                bank.AddAccount(num);
                                string claveBanco;
                                while (true)
                                {
                                   
                                    Console.WriteLine(" => Ingrese su Clave del Banco:");
                                    claveBanco = Console.ReadLine();
                                    string c2;
                                    
                                    Console.WriteLine(" => Compruebe su Clave Banco: ");
                                    c2 = Console.ReadLine();
                                    if (claveBanco == c2)
                                    {
                                        bank.AddPassword(claveBanco);
                                        int saldoDisp;
                                        Random dinero = new Random();
                                        saldoDisp = dinero.Next(10000, 500000);
                                        client = new Client(name, mail, password, rut, claveBanco, num, saldoDisp);
                                        AddClient(client);
                                        Console.WriteLine(" => Has sido Agregado con exito!!");
                                        Thread.Sleep(1000);
                                       
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(" => Su Contraseña no coincide! ");
                                        Thread.Sleep(1000);
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" => Su Contraseña no coincide!");
                                Thread.Sleep(1000);
                            }
                        }
                    }
                }
                else if (option1 == "2")
                {
                    
                    Console.WriteLine(" => Ingrese su nombre: ");
                    string name;
                    name = Console.ReadLine();
                    
                    Console.WriteLine(" => Ingrese su Rut: ");
                    int rut;
                    rut = Convert.ToInt32(Console.ReadLine());
                    if (VerificationRut2(rut))
                    {
                        Console.WriteLine(" => Este rut ya existe!!");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Clean();
                        bank.AddAdminName(rut);
                        string mail;
                        Console.WriteLine(" => Ingrese su Mail: ");
                        mail = Console.ReadLine();
                        while (true)
                        {
                            Clean();
                            string password;
                            Console.WriteLine(" => Ingrese su Clave: ");
                            password = Console.ReadLine();
                            Clean();
                            Console.WriteLine(" => Compruebe su clave: ");
                            string password2;
                            password2 = Console.ReadLine();
                            if (password == password2)
                            {
                                admin = new Admin(name, mail, password, rut, null);
                                CreateAdmin(admin);
                                Console.WriteLine(" => Has sido Agregado con exito!!");
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" => Su clave no coincide!!");
                                Thread.Sleep(1000);
                            }
                        }
                    }
                }
                else if (option1 == "3")
                {
                    Clean();
                    break;
                }
            }
        }
        public static void ClientLogin()
        {
            
            Console.WriteLine(" => Ingrese Su Rut: ");
            int rut;
            rut = Convert.ToInt32(Console.ReadLine());
            client = ClientLoginRutVerification(rut);
            
            if (client != null)
            {
                Console.WriteLine(" => Ingrese su Clave: ");
                string password;
                password = Console.ReadLine();
                client = ClientLoginPassVerification(password);
                Clean();
                while (true)
                {
                    if (client != null)
                    {
                        while (true)
                        {
                            int sald = client.GetDinero();
                            Console.WriteLine(" => Bievenido" + " " + client.GetName() + " " + "Su Saldo es: " + " " + sald);
                            Console.WriteLine(" => Los locales disponibles para comprar son: ");
                            ShowAllLocals();
                            Console.WriteLine(" => Seleccione un local o presione enter para volver atras");
                            string option4 = (Console.ReadLine());
                            if (option4 == "")
                            {

                                break;
                            }
                            else if (OptionVerification(GetLenghtLocals(), int.Parse(option4)))
                            {
                                Local local = locales[int.Parse(option4)];
                                Purchase purchase = new Purchase(local);
                                List<Product> cart = purchase.GetShoppingCart();
                                int finalPrice = purchase.FinalPrice(cart);
                                Console.WriteLine("Final Price = " + finalPrice);
                                purchase.AddToCart();
                                if (purchase.CheckDelivery())
                                {
                                    Console.WriteLine(" => Su pedido llegara en 30 minutos aproximadamente en el patio Los Ciruelos, Sala 0, para programadores.");
                                    sald -= finalPrice;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(" => Pedido estara listo para retirar en local en 30 minutos.");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine(" => Selecciona una opcion valida porfavor!!");
                                Thread.Sleep(1000);
                                continue;
                            }



                        }
                    }
                    else
                    {
                        Console.WriteLine(" => Tu Clave es Incorrecta!!");
                    }
                }
            }
            else
            {
                Console.WriteLine(" => EL RUT INGRESADO NO ESTA REGISTRADO!!");
                Console.WriteLine(" => Volviendo al inicio...");
                Thread.Sleep(3000);
            }
        }
        public static void Clean()
        {
            Console.Clear();
            Console.WriteLine("\t\t ### Fast Food ###\n");
        }
        public static bool OptionVerification(int large, int input) // new
        {

            if (input > large || input < 0)
            {
                Clean();
                return false;
            }
            else
            {
                Clean();
                return true;
            }
        }
        public static void AdminLogin()
        {
            int option2;
            Clean();
            Console.WriteLine(" => Ingrese Su Rut :");
            int rut;
            rut = Convert.ToInt32(Console.ReadLine());
            admin = AdminLoginRutVerification(rut);
            if (admin != null)
            {
                Clean();
                Console.WriteLine(" => Ingrese su Clave: ");
                string password;
                password = Console.ReadLine();
                admin = AdminLoginPassVerification(password);
                while (true)
                {
                    if (admin != null)
                    {
                        WelcomeAdmin();
                        Console.WriteLine(" => 1. Crear Nuevo Local" + Environment.NewLine + " => 2.Administrar Locales" + Environment.NewLine + " => 3.Cerrar Sesion");
                        option2 = int.Parse(Console.ReadLine());
                        OptionVerification(3, option2);
                        if (option2 == 1)
                        {
                            CreateLocalInterface();
                        }
                        else if (option2 == 2)
                        {

                            Clean();
                            if (admin.GetListLenght() == 0)
                            {
                                Console.WriteLine(" => Aun no tiene locales creados!");
                                Thread.Sleep(2000);
                                Clean();
                                continue;

                            }
                            Console.WriteLine(" => Seleccione un local: \n");
                            admin.ShowLocals();
                            Console.WriteLine(" => Respuesta: ");
                            int input = int.Parse(Console.ReadLine());
                            while (OptionVerification(admin.GetListLenght(), input))
                            {
                                List<Local> locales = admin.GetLocalList();
                                Local local = locales[input];
                                int large = admin.GetListLenght();
                                if (OptionVerification(large, input))
                                {
                                    Console.WriteLine(" => Local actual:" + " " + local.GetNameLocal()); // dar nomnre de este local 
                                    Console.WriteLine(" => Seleccione ");
                                    Console.WriteLine(" => 1) Cambiar stock    2) Cambiar Precio    3)Cambiar Delivery   4)Crear Producto");
                                    int option = int.Parse(Console.ReadLine());
                                    if (OptionVerification(4, option))
                                    {
                                        if (option == 1)
                                        {
                                            if (local.GetProductLenght() == 0)
                                            {
                                                Console.WriteLine("Aun no tiene productos creados!!!");
                                                Thread.Sleep(1000);
                                                continue;
                                            }
                                            Console.WriteLine(" => Escriba 1 para continuar: ");
                                            Clean();
                                            StockModification(local);
                                        }
                                        else if (option == 2)
                                        {
                                            if (local.GetProductLenght() == 0)
                                            {
                                                Console.WriteLine("Aun no tiene productos creados!!!");
                                                Thread.Sleep(1000);
                                                continue;
                                            }
                                            Console.WriteLine(" => Escriba 1 para continuar: ");
                                            Clean();
                                            PriceModification(local);
                                        }
                                        else if (option == 3)
                                        {
                                            if (local.GetProductLenght() == 0)
                                            {
                                                Console.WriteLine("Aun no tiene productos creados!!!");
                                                Thread.Sleep(1000);
                                                continue;
                                            }
                                            Console.WriteLine(" => Escriba 1 para continuar: ");
                                            Clean();
                                            DeliveryModification(local);
                                        }
                                        else if (option == 4)
                                        {
                                            CreateProduct(local);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Respuesta invalida!!");
                                        Thread.Sleep(2000);
                                    }
                                }
                            }
                            if (OptionVerification(admin.GetListLenght(), input))
                            {
                                Console.WriteLine("Ingresa algo valido po, no seai tonto!");
                                Thread.Sleep(2000);
                                continue;
                            }
                        }
                        else if (option2 == 3)
                        {
                            Console.WriteLine("Volviendo al inicio, aguarde un momento...");
                            Thread.Sleep(3000);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" => Tu Clave es incorreta!!");
                        Thread.Sleep(1000);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(" => EL RUT INGRESADO NO ESTA REGISTRADO!");
                Console.WriteLine(" => Volviendo al inicio...");
                Thread.Sleep(3000);

            }
        }
        public static void WelcomeAdmin()
        {

            Clean();
            Console.WriteLine("BIENVENIDO " + " " + admin.GetName() + " --->");
        }
        public static void CreateLocalInterface()
        {
            Clean();
            string name;
            string delivery;
            string direction;
            string code;
            Console.WriteLine(" => Ingrese Nombre del Local: ");
            name = Console.ReadLine();
            Clean();
            Console.WriteLine(" => Ingrese Direccion del Local: ");
            direction = Console.ReadLine();
            Clean();
            Console.WriteLine(" => Ingrese el Codigo Identificador Para su Local " + Environment.NewLine + " => Si pertenece a la Uandes Escriba Uandes seguido de su RUT" + Environment.NewLine + " => Si es fuera de la Uandes ingrese Outside seguido de su Rut");
            code = Console.ReadLine();
            Clean();
            Console.WriteLine(" => EL local tiene delivery? " + Environment.NewLine + " => (1) Si " + Environment.NewLine + " => (2) No");
            delivery = Console.ReadLine();
            if (delivery == "1")
            {
                Local local = new Local(true, null, direction, 0, name, code);
                admin.AgregarLocal(local);
                CreateLocal(local);
                Console.WriteLine(" => TU LOCAL SE HA CREADO CON EXITO!!");
                Thread.Sleep(1000);
            }
            else if (delivery == "2")
            {
                Local local = new Local(false, null, direction, 0, name, code);
                admin.AgregarLocal(local);
                CreateLocal(local);
                Console.WriteLine(" => TU LOCAL SE CREO!!");
                Thread.Sleep(1000);
            }
        }
        public static void DeliveryModification(Local currentLocal)
        {
            while (true)
            {
                if (currentLocal.GetDelivery())
                {
                    Console.WriteLine(" => Actualmente usted si tiene delivery, presione (1) para no seguir ofreciendo delivery.");
                    string line = Console.ReadLine();
                    int input = int.Parse(line);
                    if (input == 1)
                    {
                        bool False = currentLocal.GetDelivery();
                        False = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine(" => Actualmente usted no tiene delivery, presione (1) para no seguir ofreciendo delivery.");
                    string line = Console.ReadLine();
                    int input = int.Parse(line);
                    if (input == 1)
                    {
                        bool True = currentLocal.GetDelivery();
                        True = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        public static void StockModification(Local currentLocal)
        {
            List<Product> menu = currentLocal.GetMenu();
            string linea = Console.ReadLine();
            int input = int.Parse(linea);
            int largeMenu = menu.Count;
            while (true)
            {
                Console.WriteLine(" => Elija un producto para modificar su stock: ");
                for (int i = 0; i < largeMenu; i++)
                {
                    Product producto = menu[i];
                    string productName = producto.GetName();
                    int stock = producto.GetStock();
                    Console.WriteLine(String.Format("\t{0}. {1} - Stock:{2}", i, productName, stock));
                }
                Console.Write("=> Su respuesta: ");
                linea = Console.ReadLine();
                if (linea == "")
                {
                    Console.WriteLine(" => Volviendo al inicio...");
                    Thread.Sleep(2000);
                    break;
                }
                input = int.Parse(linea);
                if (input >= largeMenu || input < 0)
                {
                    Console.WriteLine(" => Opcion incorrecta, intente nuevamente!");
                    Thread.Sleep(1000);
                    Clean();
                    continue;
                }
                else
                {
                    Product product = menu[input];
                    Console.WriteLine(" => Ingrese stock: ");
                    input = int.Parse(Console.ReadLine());
                    product.NewStock(input);
                    Console.WriteLine(" => Stock actualizado!");
                    Thread.Sleep(2000);
                    break;
                }
            }
        }
        public static void PriceModification(Local currentLocal)
        {
            currentLocal.ListProducts();
            List<Product> menu = currentLocal.GetMenu();
            string line = Console.ReadLine();
            int input = int.Parse(line);
            int largeMenu = menu.Count;
            while (true)
            {
                Console.WriteLine(" => Elija un producto para modificar su precio: ");
                for (int i = 0; i < largeMenu; i++)
                {
                    Product producto = menu[i];
                    string productName = producto.GetName();
                    int productPrice = producto.GetPrice();
                    Console.WriteLine(String.Format("\t{0}. {1} - ${2}", i, productName, productPrice));
                }
                Console.Write(" => Su respuesta: ");
                line = Console.ReadLine();
                if (line == "")
                {
                    Console.WriteLine(" => Volviendo al inicio...");
                    Thread.Sleep(2000);
                    break;
                }
                input = int.Parse(line);
                if (input >= largeMenu || input < 0)
                {
                    Console.WriteLine(" => Opcion incorrecta, intente nuevamente");
                    Thread.Sleep(1000);
                    Clean();
                    continue;
                }
                else
                {
                    Product product = menu[input];
                    Console.WriteLine(" => Ingrese precio: ");
                    input = int.Parse(Console.ReadLine());
                    product.NewPrice(input);
                    Console.WriteLine(" => Precio Actualizado correctamente");
                    Thread.Sleep(2000);
                    break;
                }
            }
        }
        public static void CreateProduct(Local local)
        {
            while (true)
            {
                int option;
                if (local.GetProductLenght() == 0)
                {
                    Console.WriteLine(" => Aun no tiene productos creados!");
                }
                else
                {
                    Console.WriteLine(" => Tus Productos Son: ");
                    local.ListProducts();
                }
                Console.WriteLine(" => Ingrese nombre del producto: ");
                string name = Console.ReadLine();
                Clean();
                Console.WriteLine(" => Ingrese PRecio del producto");
                int price = int.Parse(Console.ReadLine());
                Clean();
                Console.WriteLine(" => Ingrese stock del producto");
                int stock = int.Parse(Console.ReadLine());
                Clean();
                Product product = new Product(stock, name, price);
                local.AddProduct(product);
                Console.WriteLine(" => Desea agregar mas productos" + Environment.NewLine + " => (0) Si" + Environment.NewLine + " => (1) No");
                option = int.Parse(Console.ReadLine());
                if (OptionVerification(1, option))
                {
                    if (option == 1)
                    {
                        Console.WriteLine(" => Producto Agregado correctamente!");
                        Thread.Sleep(1000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" => Producto Agregado correctamente!");
                        Thread.Sleep(1000);
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine(" => OPCION INCORRECTA, INTENTE DE NUEVO!!");
                    Thread.Sleep(2000);
                    continue;
                }
            }
        }
        public static void ShowAllLocals()
        {
            int i = 0;
            foreach (Local local in locales)
            {
                Console.WriteLine("\t" + i + ".- \t\t Local " + local.GetNameLocal());
                i++;
            }
        }
        public static int GetLenghtLocals()
        {
            int lenght = locales.Count();
            return lenght;
        }

    }
}



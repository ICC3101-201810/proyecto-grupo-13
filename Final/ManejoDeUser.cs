using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    class UsserManagment
    {
        List<Client> clients;
        List<Admin> admins;
        List<Local> locales;
        public Bank bank;
        public Admin admin;
        public Client client;
        public UsserManagment(List<Client> clients, List<Local> locales, Bank bank)
        {
            this.clients = new List<Client>();
            this.admins = new List<Admin>();
            this.locales = new List<Local>();
            this.bank = bank;
        }


        public void DescribeLocals2()
        {
            admin.DescribirLocales
            int LargoLocales =
            for (Local l in locales)
            {
                Console.WriteLine(l.GetNameLocal());
            }
        }
        public void AddClient(Client client)
        {
            this.clients.Add(client);
        }
        public void CreateAdmin(Admin admin)
        {
            this.admins.Add(admin);

        }
        public void CreateLocal(Local local)
        {
            locales.Add(local);
        }
        public bool VerificationRut2(int Rut)
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
        public bool ClientRutVerification(int Rut)
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
        public Client ClientLoginRutVerification(int rut)
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
        public Client ClientLoginPassVerification(string password)
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
        public Admin AdminRutVerification(int rut)
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
        public Admin AdminLoginRutVerification(int rut) // para registrar
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
        public Admin AdminLoginPassVerification(string password)
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
        public void CreateMenu()
        {
            while (true)
            {
                Console.WriteLine("1.Nuevo Cliente" + Environment.NewLine + "2.Nuevo Administrador de Locales" + Environment.NewLine + "3.Salir");
                string option1;
                option1 = Convert.ToString(Console.ReadLine());
                if (option1 == "1")
                {
                    Console.WriteLine("Ingrese su nombre");
                    string name;
                    name = Console.ReadLine();
                    Console.WriteLine("Ingrese su Rut");
                    int rut;
                    rut = Convert.ToInt32(Console.ReadLine());
                    if (ClientRutVerification(rut))
                    {
                        Console.WriteLine("Este rut ya existe");
                    }
                    else
                    {
                        string mail;
                        Console.WriteLine("Ingrese su Mail");
                        mail = Console.ReadLine();
                        while (true)
                        {
                            string password;
                            Console.WriteLine("Ingrese su Clave: ");
                            password = Console.ReadLine();
                            Console.WriteLine("Compruebe su clave: ");
                            string clave2;
                            clave2 = Console.ReadLine();
                            if (password == clave2)
                            {
                                Console.WriteLine("Ingrese su Numero de Cuenta");
                                string num;
                                num = Convert.ToString(Console.ReadLine());
                                bank.AddAccount(num);
                                string claveBanco;
                                while (true)
                                {
                                    Console.WriteLine("Ingrese su Clave del Banco");
                                    claveBanco = Console.ReadLine();
                                    string c2;
                                    Console.WriteLine("Compruebe su clave Banco");
                                    c2 = Console.ReadLine();
                                    if (claveBanco == c2)
                                    {
                                        bank.AddPassword(claveBanco);
                                        int saldoDisp;
                                        Random dinero = new Random();
                                        saldoDisp = dinero.Next(10000, 500000);
                                        client = new Client(name, mail, password, rut, claveBanco, num, saldoDisp);
                                        AddClient(client);
                                        Console.WriteLine("Has sido Agregado con exito");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Su Contraseña no coincide ");
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Su Contraseña no coincide ");
                            }
                        }
                    }
                }
                else if (option1 == "2")
                {
                    Console.WriteLine("Ingrese su nombre");
                    string name;
                    name = Console.ReadLine();
                    Console.WriteLine("Ingrese su Rut");
                    int rut;
                    rut = Convert.ToInt32(Console.ReadLine());
                    if (VerificationRut2(rut))
                    {
                        Console.WriteLine("Este rut ya existe");
                    }
                    else
                    {
                        bank.AddAdminName(rut);
                        string mail;
                        Console.WriteLine("Ingrese su Mail");
                        mail = Console.ReadLine();
                        while (true)
                        {
                            string password;
                            Console.WriteLine("Ingrese su Clave: ");
                            password = Console.ReadLine();
                            Console.WriteLine("Compruebe su clave: ");
                            string password2;
                            password2 = Console.ReadLine();
                            if (password == password2)
                            {
                                admin = new Admin(name, mail, password, rut, null);
                                CreateAdmin(admin);
                                Console.WriteLine("Has sido Agregado con exito");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Su clave no coincide");
                            }
                        }
                    }
                }
                else if (option1 == "3")
                {
                    break;
                }
            }
        }
        public void AdminLogin()
        {
            Console.WriteLine("Ingrese Su Rut :");
            int rut;
            rut = Convert.ToInt32(Console.ReadLine());
            admin = this.AdminLoginRutVerification(rut);
            if (admin != null)
            {
                Console.WriteLine("Ingrese su Clave: ");
                string password;
                password = Console.ReadLine();
                admin = this.AdminLoginPassVerification(password);
                while (true)
                {
                    if (admin != null)
                    {
                        Console.WriteLine("Bienvenido" + " " + admin.GetName());
                        string option2;
                        Console.WriteLine("1. Crear Nuevo Local" + Environment.NewLine + "2.Administrar Locales" + Environment.NewLine + "3.Cerrar Sesion");
                        option2 = Convert.ToString(Console.ReadLine());
                        while (true)
                        {
                            if (option2 == "1")
                            {
                                string name;
                                string delivery;
                                string direction;
                                Console.WriteLine("Ingrese Nombre del Local :");
                                name = Console.ReadLine();
                                Console.WriteLine("Ingrese Direccion del Local :");
                                direction = Console.ReadLine();
                                Console.WriteLine("Ingrese el Codigo Identificador Para su Local " + Environment.NewLine + "Si pertenece a la Uandes Escriba Uandes seguido de su RUT" + Environment.NewLine + "Si es fuera de la Uandes ingrese Outside seguido de su Rut");
                                string code;
                                code = Console.ReadLine();
                                Console.WriteLine("El Local tiene Delivery" + Environment.NewLine + "1.Si" + Environment.NewLine + "2.No");
                                delivery = Convert.ToString(Console.ReadLine());
                                if (delivery == "1")
                                {
                                    Local local = new Local(true, null, direction, 0, name, code);
                                    admin.AgregarLocal(local);
                                    CreateLocal(local);
                                    Console.WriteLine("Desea Agregar Productos Ahora Para este Local" + Environment.NewLine + "1.Si" + Environment.NewLine + "2.No");
                                    string option3;
                                    option3 = Convert.ToString(Console.ReadLine());
                                    if (option3 == "1")
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("Tus Productos son: ");
                                            local.ListProducts();
                                            Console.WriteLine("Ingrese Nombre del Producto: ");
                                            string nprod;
                                            int stock;
                                            int price;
                                            nprod = Console.ReadLine();
                                            Console.WriteLine("Ingrese Precio del Producto :");
                                            price = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock del Producto :");
                                            stock = Convert.ToInt32(Console.ReadLine());
                                            Product producto = new Product(stock, nprod, price);
                                            local.AddProduct(producto);
                                            Console.WriteLine("Desea Agregar Mas Productos" + Environment.NewLine + "1.Si" + Environment.NewLine + "2.No");
                                            string op0;
                                            op0 = Convert.ToString(Console.ReadLine());
                                            if (op0 == "2")
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                                else if (delivery == "2")
                                {
                                    Local local = new Local(false, null, direction, 0, name, code);
                                    admin.AgregarLocal(local);
                                    CreateLocal(local);
                                    Console.WriteLine("Desea Agregar Productos Ahora Para este Local" + Environment.NewLine + "1.Si" + Environment.NewLine + "2.No");
                                    string option3;
                                    option3 = Convert.ToString(Console.ReadLine());
                                    if (option3 == "1")
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("Tus Productos son: ");
                                            local.ListProducts();
                                            Console.WriteLine("Ingrese Nombre del Producto: ");
                                            string nprod;
                                            int stock;
                                            int price;
                                            nprod = Console.ReadLine();
                                            Console.WriteLine("Ingrese Precio del Producto :");
                                            price = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock del Producto :");
                                            stock = Convert.ToInt32(Console.ReadLine());
                                            Product producto = new Product(stock, nprod, price);
                                            local.AddProduct(producto);
                                            Console.WriteLine("Desea Agregar Mas Productos" + Environment.NewLine + "1.Si" + Environment.NewLine + "2.No");
                                            string op0;
                                            op0 = Convert.ToString(Console.ReadLine());
                                            if (op0 == "2")
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            else if (option2 == "2")
                            {
                                // string opcion3;
                                Console.WriteLine("Los locales son:");
                                this.admin.DescribirLocales();
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tu Clave es incorreta");
                    }
                    break;
                }
            }
            else
            {
                Console.WriteLine("ESTE RUT NO ESTA INSCRITO EN NUESTRAS BASE DE DATOS COMO ADMINISTRADOR DE LOCAL");
            }
        }
        public void LoginClient()
        {
            Console.WriteLine("Ingrese Su Rut");
            int rut;
            rut = Convert.ToInt32(Console.ReadLine());
            client = this.ClientLoginRutVerification(rut);
            if (client != null)
            {
                Console.WriteLine("Ingrese su Clave: ");
                string password;
                password = Console.ReadLine();
                client = this.ClientLoginPassVerification(password);
                while (true)
                {
                    if (client != null)
                    {
                        while (true)
                        {
                            Console.WriteLine("Bievenido" + " " + client.GetName() + " " + "Su Saldo es: " + " " + client.GetDinero());
                            Console.WriteLine("Que Desea Hacer" + Environment.NewLine + "1.Comprar" + Environment.NewLine + "2. Ver Locales" + "3.Cerrar Sesion");
                            string option4;
                            option4 = Convert.ToString(Console.ReadLine());
                            if (option4 == "1")
                            {
                                
                            }
                            else if (option4 == "2")
                            {
                                Console.WriteLine("Los Locales son : ");
                                DescribeLocals2();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tu Clave es Incorrecta");
                    }
                }
            }
            else
            {
                Console.WriteLine("Este rut no esta registrado en nuestra base de datos");
            }
        }
    }
}


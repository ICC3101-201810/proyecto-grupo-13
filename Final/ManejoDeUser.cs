using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    class ManejoDeUsuario
    {
        List<Client> clients;
        List<Admin> admins;
        List<Local> locales;
        public Bank bank;
        public Admin admin;
        public Client client;
        public ManejoDeUsuario(List<Client> clients, List<Local> locales, Bank bank)
        {
            this.clients = new List<Client>();
            this.admins = new List<Admin>();
            this.locales = new List<Local>();
            this.bank = bank;
        }


        public void DescribriLocales2()
        {
            admin.DescribirLocales
            int LargoLocales =
            for (Local l in locales)
            {
                Console.WriteLine(l.GetNameLocal());
            }
        }
        public void CrearCliente(Client client)
        {
            this.clients.Add(client);
        }
        public void CrearAdmin(Admin admin)
        {
            this.admins.Add(admin);

        }
        public void CrearLocal(Local local)
        {
            locales.Add(local);
        }
        public bool VerificarRut2(int Rut)
        {
            foreach (Admin a in admins)
            {
                if (a.GetRut() == Rut)
                {
                    return true;
                }
            }
            return false;
        }
        public bool VerificarRut(int Rut)
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
        public Client VerificarRutInicioDeSesion(int rut)
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
        public Client VerificarClaveClientInicioDeSesion(string clave)
        {
            foreach (Client c in clients)
            {
                if (c.GetClave() == clave)
                {
                    return c;
                }
            }
            return null;
        }
        public Admin VerificarRutAdmin(int rut)
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
        public Admin VerificarRutAdminIncioDeSesion(int rut) // para registrar
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
        public Admin VerificarClaveAdminInicioDeSesion(string clave)
        {
            foreach (Admin a in admins)
            {
                if (a.GetClave() == clave)
                {
                    return a;
                }
            }
            return null;
        }
        public void CrearMenu()
        {
            while (true)
            {
                Console.WriteLine("1.Nuevo Cliente" + Environment.NewLine + "2.Nuevo Administrador de Locales" + Environment.NewLine + "3.Salir");
                string opcion1;
                opcion1 = Convert.ToString(Console.ReadLine());
                if (opcion1 == "1")
                {
                    Console.WriteLine("Ingrese su nombre");
                    string Nombre;
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su Rut");
                    int rut;
                    rut = Convert.ToInt32(Console.ReadLine());
                    if (VerificarRut(rut))
                    {
                        Console.WriteLine("Este rut ya existe");
                    }
                    else
                    {
                        string Mail;
                        Console.WriteLine("Ingrese su Mail");
                        Mail = Console.ReadLine();
                        while (true)
                        {
                            string Clave;
                            Console.WriteLine("Ingrese su Clave: ");
                            Clave = Console.ReadLine();
                            Console.WriteLine("Compruebe su clave: ");
                            string clave2;
                            clave2 = Console.ReadLine();
                            if (Clave == clave2)
                            {
                                Console.WriteLine("Ingrese su Numero de Cuenta");
                                string num;
                                num = Convert.ToString(Console.ReadLine());
                                bank.AgregarCuenta(num);
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
                                        bank.AgregarClave(claveBanco);
                                        int SaldoDisp;
                                        Random dinero = new Random();
                                        SaldoDisp = dinero.Next(10000, 500000);
                                        client = new Client(Nombre, Mail, Clave, rut, claveBanco, num, SaldoDisp);
                                        CrearCliente(client);
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
                else if (opcion1 == "2")
                {
                    Console.WriteLine("Ingrese su nombre");
                    string Nombre;
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su Rut");
                    int rut;
                    rut = Convert.ToInt32(Console.ReadLine());
                    if (VerificarRut2(rut))
                    {
                        Console.WriteLine("Este rut ya existe");
                    }
                    else
                    {
                        bank.AgregarNombreAdmin(rut);
                        string Mail;
                        Console.WriteLine("Ingrese su Mail");
                        Mail = Console.ReadLine();
                        while (true)
                        {
                            string Clave;
                            Console.WriteLine("Ingrese su Clave: ");
                            Clave = Console.ReadLine();
                            Console.WriteLine("Compruebe su clave: ");
                            string clave2;
                            clave2 = Console.ReadLine();
                            if (Clave == clave2)
                            {
                                admin = new Admin(Nombre, Mail, Clave, rut, null);
                                CrearAdmin(admin);
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
                else if (opcion1 == "3")
                {
                    break;
                }
            }
        }
        public void InicioSesionAdmin()
        {
            Console.WriteLine("Ingrese Su Rut :");
            int rut;
            rut = Convert.ToInt32(Console.ReadLine());
            admin = this.VerificarRutAdminIncioDeSesion(rut);
            if (admin != null)
            {
                Console.WriteLine("Ingrese su Clave: ");
                string clave;
                clave = Console.ReadLine();
                admin = this.VerificarClaveAdminInicioDeSesion(clave);
                while (true)
                {
                    if (admin != null)
                    {
                        Console.WriteLine("Bienvenido" + " " + admin.GetName());
                        string opcion2;
                        Console.WriteLine("1. Crear Nuevo Local" + Environment.NewLine + "2.Administrar Locales" + Environment.NewLine + "3.Cerrar Sesion");
                        opcion2 = Convert.ToString(Console.ReadLine());
                        while (true)
                        {
                            if (opcion2 == "1")
                            {
                                string nombre;
                                string delivery;
                                string direccion;
                                Console.WriteLine("Ingrese Nombre del Local :");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese Direccion del Local :");
                                direccion = Console.ReadLine();
                                Console.WriteLine("Ingrese el Codigo Identificador Para su Local " + Environment.NewLine + "Si pertenece a la Uandes Escriba Uandes seguido de su RUT" + Environment.NewLine + "Si es fuera de la Uandes ingrese Outside seguido de su Rut");
                                string cod;
                                cod = Console.ReadLine();
                                Console.WriteLine("El Local tiene Delivery" + Environment.NewLine + "1.Si" + Environment.NewLine + "2.No");
                                delivery = Convert.ToString(Console.ReadLine());
                                if (delivery == "1")
                                {
                                    Local local = new Local(true, null, direccion, 0, nombre, cod);
                                    admin.AgregarLocal(local);
                                    CrearLocal(local);
                                    Console.WriteLine("Desea Agregar Productos Ahora Para este Local" + Environment.NewLine + "1.Si" + Environment.NewLine + "2.No");
                                    string opcion3;
                                    opcion3 = Convert.ToString(Console.ReadLine());
                                    if (opcion3 == "1")
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("Tus Productos son: ");
                                            local.DescribirProductos();
                                            Console.WriteLine("Ingrese Nombre del Producto: ");
                                            string nprod;
                                            int Stock;
                                            int Precio;
                                            nprod = Console.ReadLine();
                                            Console.WriteLine("Ingrese Precio del Producto :");
                                            Precio = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock del Producto :");
                                            Stock = Convert.ToInt32(Console.ReadLine());
                                            Producto producto = new Producto(Stock, nprod, Precio);
                                            local.AgregarProducto(producto);
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
                                    Local local = new Local(false, null, direccion, 0, nombre, cod);
                                    admin.AgregarLocal(local);
                                    CrearLocal(local);
                                    Console.WriteLine("Desea Agregar Productos Ahora Para este Local" + Environment.NewLine + "1.Si" + Environment.NewLine + "2.No");
                                    string opcion3;
                                    opcion3 = Convert.ToString(Console.ReadLine());
                                    if (opcion3 == "1")
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("Tus Productos son: ");
                                            local.DescribirProductos();
                                            Console.WriteLine("Ingrese Nombre del Producto: ");
                                            string nprod;
                                            int Stock;
                                            int Precio;
                                            nprod = Console.ReadLine();
                                            Console.WriteLine("Ingrese Precio del Producto :");
                                            Precio = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ingrese Stock del Producto :");
                                            Stock = Convert.ToInt32(Console.ReadLine());
                                            Producto producto = new Producto(Stock, nprod, Precio);
                                            local.AgregarProducto(producto);
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
                            else if (opcion2 == "2")
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
        public void InicioSesionClient()
        {
            Console.WriteLine("Ingrese Su Rut");
            int rut;
            rut = Convert.ToInt32(Console.ReadLine());
            client = this.VerificarRutInicioDeSesion(rut);
            if (client != null)
            {
                Console.WriteLine("Ingrese su Clave: ");
                string clave;
                clave = Console.ReadLine();
                client = this.VerificarClaveClientInicioDeSesion(clave);
                while (true)
                {
                    if (client != null)
                    {
                        while (true)
                        {
                            Console.WriteLine("Bievenido" + " " + client.GetName() + " " + "Su Saldo es: " + " " + client.GetDinero());
                            Console.WriteLine("Que Desea Hacer" + Environment.NewLine + "1.Comprar" + Environment.NewLine + "2. Ver Locales" + "3.Cerrar Sesion");
                            string opcion4;
                            opcion4 = Convert.ToString(Console.ReadLine());
                            if (opcion4 == "1")
                            {
                                
                            }
                            else if (opcion4 == "2")
                            {
                                Console.WriteLine("Los Locales son : ");
                                DescribriLocales2();
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

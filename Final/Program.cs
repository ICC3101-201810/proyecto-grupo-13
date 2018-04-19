using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(null, null, null, null);
            Client client0 = new Client("Javier Contreras", "jicontreras@miuandes.cl", "javier123", 194335670, "jcon123", "1234", 50000);
            Client client1 = new Client("Magdalena Perez", "mpperez@miuandes.cl", "copito33", 186569992, "hola54", "003424222", 700000);
            Producto PapasFritas = new Producto(60, "Papas Fritas", 800);
            Producto HamburguesaQueso = new Producto(80, "Hamburguesa con Queso", 2500);
            Producto EnsaladaCesar = new Producto(80, "Ensalada Cesar", 3000);
            Producto TeHelado = new Producto(150, "Te Helado Durazno", 650);
            Local local0 = new Local(true, null, "Universidad de los Andes", 1000000, "Coffe Time", "Uandes00");
            local0.AgregarProducto(PapasFritas);
            local0.AgregarProducto(HamburguesaQueso);
            local0.AgregarProducto(TeHelado);
            Local local1 = new Local(false, null, "Universidad de los Andes", 4000000, "Picnik", "Uandes01");
            local1.AgregarProducto(EnsaladaCesar);
            local1.AgregarProducto(TeHelado);
            Admin admin0 = new Admin("Cesar Thor", "cesarthor@gmaill.com", "pezdorado", 129007655, null);
            admin0.AgregarLocal(local1);
            Admin admin1 = new Admin("Rocio Sting", "chiosting@hotmail.com", "chiobacan1975", 91109805, null);
            admin1.AgregarLocal(local0);
            ManejoDeUsuario mu = new ManejoDeUsuario(null, null, bank);
            mu.CrearAdmin(admin0);
            mu.CrearAdmin(admin1);
            mu.CrearCliente(client0);
            mu.CrearCliente(client1);
            mu.CrearLocal(local0);
            mu.CrearLocal(local1);
            admin0.DescribirLocales();
            int j = 0;
            while (j == 0)
            {
                Console.WriteLine("Bienvenido a FastLaunch");
                Console.WriteLine("1.Registrarse" + Environment.NewLine + "2.Iniciar Sesion");
                string opcion0;
                opcion0 = Convert.ToString(Console.ReadLine());
                Console.Clear();
                if (opcion0 == "1")
                {
                    mu.CrearMenu();
                }
                else if (opcion0 == "2")
                {
                    string var01;
                    Console.WriteLine("1.Cliente" + Environment.NewLine + "2.Administrador de Locales");
                    var01 = Convert.ToString(Console.ReadLine());
                    if (var01 == "1")
                    {
                        mu.InicioSesionClient();
                    }
                    else if (var01 == "2")
                    {
                        mu.InicioSesionAdmin();
                    }

                }
            }
        }
    }
}

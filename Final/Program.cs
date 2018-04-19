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
            Product PapasFritas = new Product(60, "Papas Fritas", 800);
            Product HamburguesaQueso = new Product(80, "Hamburguesa con Queso", 2500);
            Product EnsaladaCesar = new Product(80, "Ensalada Cesar", 3000);
            Product TeHelado = new Product(150, "Te Helado Durazno", 650);
            Local local0 = new Local(true, null, "Universidad de los Andes", 1000000, "Coffe Time", "Uandes00");
            local0.AddProduct(PapasFritas);
            local0.AddProduct(HamburguesaQueso);
            local0.AddProduct(TeHelado);
            Local local1 = new Local(false, null, "Universidad de los Andes", 4000000, "Picnik", "Uandes01");
            local1.AddProduct(EnsaladaCesar);
            local1.AddProduct(TeHelado);
            Admin admin0 = new Admin("Cesar Thor", "cesarthor@gmaill.com", "pezdorado", 129007655, null);
            admin0.AgregarLocal(local1);
            Admin admin1 = new Admin("Rocio Sting", "chiosting@hotmail.com", "chiobacan1975", 91109805, null);
            admin1.AgregarLocal(local0);
            UsserManagment usserManganment = new UsserManagment(null, null, bank);
            usserManganment.CreateAdmin(admin0);
            usserManganment.CreateAdmin(admin1);
            usserManganment.AddClient(client0);
            usserManganment.AddClient(client1);
            usserManganment.CreateLocal(local0);
            usserManganment.CreateLocal(local1);
            admin0.DescribirLocales();
            int j = 0;
            while (j == 0)
            {
                Console.WriteLine("Bienvenido a FastLaunch");
                Console.WriteLine("1.Registrarse" + Environment.NewLine + "2.Iniciar Sesion");
                string option0;
                option0 = Convert.ToString(Console.ReadLine());
                Console.Clear();
                if (option0 == "1")
                {
                    usserManganment.CreateMenu();
                }
                else if (option0 == "2")
                {
                    string var01;
                    Console.WriteLine("1.Cliente" + Environment.NewLine + "2.Administrador de Locales");
                    var01 = Convert.ToString(Console.ReadLine());
                    if (var01 == "1")
                    {
                        usserManganment.LoginClient();
                    }
                    else if (var01 == "2")
                    {
                        usserManganment.AdminLogin();
                    }

                }
            }
        }
    }
}

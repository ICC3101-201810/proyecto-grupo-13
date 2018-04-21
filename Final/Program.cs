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
            List<Product> menu = new List<Product>()
            {
                new Product(20,"Papas Fritas Italiana",1000),
                new Product(10,"Roll de Sushi Italiano",3000),
                new Product(25,"Hamburguesa Italiana",1500),
                new Product(5,"Menu del dia",5000),
                new Product(20,"Pure Italiano",3593)
            };
            Bank bank = new Bank(null, null, null, null);
            Client client0 = new Client("Javier Contreras", "jicontreras@miuandes.cl", "javier123", 194335670, "JabonDeBaño", "006965348219", 50000);
            Client client1 = new Client("Magdalena Perez", "mpperez@miuandes.cl", "copito33", 186569992, "Almhoada", "003424222487", 700000);
            Client client2 = new Client("Omar Oyarce", "oioyarce@miuandes.cl", "Paloma1997", 194752075, "escoba", "007031342419", 500000);
            Client client3 = new Client("Carmen Torres", "cptorres@miuandes.cl", "Alcon2001", 186569992, "trapero", "009802765418", 100000);
            Client client4 = new Client("Matias Cabezas", "mccabezas@miuandes.cl", "Pulpo6969", 186569992, "Pito420", "008728365417", 300000);
            Product papasFritas = new Product(60, "Papas Fritas", 800);
            Product hamburguesaQueso = new Product(80, "Hamburguesa con Queso", 2500);
            Product ensaladaCesar = new Product(80, "Ensalada Cesar", 3000);
            Product teHelado = new Product(150, "Te Helado Durazno", 650);
            Product sushi_Italiano = new Product(20, "Sushi Italiano", 2500);
            Local local0 = new Local(true, null, "Universidad de los Andes", 1000000, "Coffe Time", "Uandes00");
            Local local1 = new Local(false, null, "Clinica Universidad de los Andes", 4000000, "Picnik", "Uandes01");
            Local local2 = new Local(true, null, "Bar Universidad de los Andes", 999999, "Drink Time", "Uandes02");
            Local local3 = new Local(false, null, "Estadio Universidad de los Andes", 69000, "Sport Time", "Uandes03");
            Local local4 = new Local(false, null, "Club Universidad de los Andes", 100000, "Farra Time", "Uandes04");
            Admin admin0 = new Admin("Omar", "cesarthor@gmaill.com", "Paloma1997", 194752075, null);
            Admin admin1 = new Admin("Rocio Sting", "chiosting@hotmail.com", "chiobacan1975", 91109805, null);
            Admin one = new Admin("Omarcito69", "2", "1", 1, null);
            Client one1 = new Client("Omar Oyarce", "oioyarce@miuandes.cl", "1", 1, "escoba", "007031342419", 500000);
            UserManagment userManganment = new UserManagment(null, null, bank);
            local0.AddProduct(papasFritas);
            local0.AddProduct(hamburguesaQueso);
            local0.AddProduct(teHelado);
            local1.AddProduct(ensaladaCesar);
            local1.AddProduct(teHelado);
            local0.AddProduct(sushi_Italiano);
            admin0.AgregarLocal(local0);
            admin0.AgregarLocal(local1);
            admin1.AgregarLocal(local2);
            admin1.AgregarLocal(local3);
            admin1.AgregarLocal(local4);
            userManganment.AddClient(one1);
            userManganment.CreateAdmin(admin0);
            userManganment.CreateAdmin(admin1);
            userManganment.CreateAdmin(one);
            userManganment.AddClient(client0);
            userManganment.AddClient(client1);
            userManganment.AddClient(client2);
            userManganment.AddClient(client3);
            userManganment.AddClient(client4);
            userManganment.CreateLocal(local0);
            userManganment.CreateLocal(local1);
            userManganment.CreateLocal(local2);
            userManganment.CreateLocal(local3);
            userManganment.CreateLocal(local4);
            while (true)
            {
                userManganment.Clean();
                Console.WriteLine(" => 1.Registrarse" + Environment.NewLine + " => 2.Iniciar Sesion");
                string option0;
                option0 = Convert.ToString(Console.ReadLine());
                Console.Clear();
                if (option0 == "1")
                {
                    userManganment.CreateUserInterface();
                }
                else if (option0 == "2")
                {
                    string var01;
                    Console.WriteLine("\t\t ### Fast Food ###\n");
                    Console.WriteLine(" => 1.Cliente" + Environment.NewLine + " => 2.Administrador de Locales");
                    var01 = Convert.ToString(Console.ReadLine());
                    if (var01 == "1")
                    {
                        userManganment.ClientLogin();
                    }
                    else if (var01 == "2")
                    {
                        userManganment.AdminLogin();
                    }

                }
            }
        }
    }
}

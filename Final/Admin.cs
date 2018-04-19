using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    public class Admin : Usser
    {
        List<Local> locales;
        public Admin(string Nombre, string Mail, string Clave, int Rut, List<Local> locales) : base(Nombre, Mail, Clave, Rut)
        {
            this.locales = new List<Local>();
        }
        public void AgregarLocal(Local local)
        {
            locales.Add(local);
        }
        public void DescribirLocales()
        {
            foreach (Local local in locales)
            {
                Console.WriteLine(local.GetNameLocal());
            }
        }
    }
}

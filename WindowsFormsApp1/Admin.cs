using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    public class Admin : Usser
    {
        public List<Local> locales;
      
        public Admin(string Nombre, string Mail, string Clave, int Rut, List<Local> locales) : base(Nombre, Mail, Clave, Rut)
        {
            this.locales = new List<Local>();
        }
        public void AgregarLocal(Local local)
        {
            locales.Add(local);
        }
        public void BorrarLocal (Local local)
        {
            locales.Remove(local);
        }
        public void ShowLocals()
        {
            int i = 0;
            foreach (Local local in locales)
            {
                Console.WriteLine("\t"+ i +".-   Local "+local.GetNameLocal()+"\n");
                i++;
            }
        }
        public int GetListLenght()
        {
            int lenght = locales.Count();
            return lenght;
        }
        public List<Local> GetLocalList()
        {
            return locales;
        }
       
    }
}

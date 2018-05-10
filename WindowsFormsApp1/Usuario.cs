using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    public abstract class Usser
    {

        string name;
        string mail;
        string password;
        int rut;
        public Usser(string Nombre, string Mail, string Clave, int Rut)
        {
            this.name = Nombre;
            this.mail = Mail;
            this.password = Clave;
            this.rut = Rut;
        }
        public string GetName() { return this.name; }
        public int GetRut() { return this.rut; }
        public string GetMail() { return this.mail; }
        public string GetClave() { return this.password; }
    }
}
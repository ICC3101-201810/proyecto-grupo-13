using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    public abstract class Usuario
    {

        string Nombre;
        string Mail;
        string Clave;
        int Rut;
        public Usuario(string Nombre, string Mail, string Clave, int Rut)
        {
            this.Nombre = Nombre;
            this.Mail = Mail;
            this.Clave = Clave;
            this.Rut = Rut;
        }
        public string GetName() { return this.Nombre; }
        public int GetRut() { return this.Rut; }
        public string GetMail() { return this.Mail; }
        public string GetClave() { return this.Clave; }
    }
}
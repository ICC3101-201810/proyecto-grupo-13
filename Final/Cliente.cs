using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    public class Client : Usuario
    {
        string ClaveCuenta;
        string NdeCuenta;
        int Billetera;

        public Client(string Nombre, string Mail, string Clave, int Rut, string ClaveCuenta, string NdeCuenta, int Billetera) : base(Nombre, Mail, Clave, Rut)
        {
            this.ClaveCuenta = ClaveCuenta;
            this.NdeCuenta = NdeCuenta;
            this.Billetera = Billetera;

        }

        public string GetClaveCuenta() { return ClaveCuenta; }
        public string GetNdeCuenta() { return this.NdeCuenta; }
        public int GetDinero() { return Billetera; }


    }
}

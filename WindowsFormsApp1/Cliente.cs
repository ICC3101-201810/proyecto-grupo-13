using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace WindowsFormsApp1
{
    [Serializable()]
    public class Client : Usser
    {
        string passAccount;
        string numberAccount;
        int moneyAccount;

        public Client(string Nombre, string Mail, string Clave, int Rut, string ClaveCuenta, string NdeCuenta, int Billetera) : base(Nombre, Mail, Clave, Rut)
        {
            this.passAccount = ClaveCuenta;
            this.numberAccount = NdeCuenta;
            this.moneyAccount = Billetera;

        }
        public string GetClaveCuenta() { return passAccount; }
        public string GetNdeCuenta() { return this.numberAccount; }
        public int GetDinero() { return this.moneyAccount; }
        public void DecreaseWallet(int input)
        {
            this.moneyAccount -= input;
        }
    }
}

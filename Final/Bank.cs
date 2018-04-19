using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    public class Bank
    {
        List<string> Cuentas;
        List<string> Claves;
        List<int> RutAdmin;
        List<int> DineroAcumulado;
        public Bank(List<string> Cuentas, List<string> Claves, List<int> RutAdmin, List<int> DineroAcumulado)
        {
            this.Cuentas = new List<string>();
            this.Claves = new List<string>();
            this.RutAdmin = new List<int>();
            this.DineroAcumulado = new List<int>();


        }
        public void AgregarCuenta(string cuenta)
        {
            Cuentas.Add(cuenta);

        }
        public void AgregarClave(string clave)
        {
            Claves.Add(clave);
        }
        public void AgregarNombreAdmin(int rut)
        {
            RutAdmin.Add(rut);

        }
        public void AgregarDineroAcumulado(int Saldo)
        {
            DineroAcumulado.Add(Saldo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    public class Bank
    {
        List<string> accounts;
        List<string> passwords;
        List<int> rutAdmin;
        List<int> moneyAccumulate;
        public Bank(List<string> Cuentas, List<string> Claves, List<int> RutAdmin, List<int> DineroAcumulado)
        {
            this.accounts = new List<string>();
            this.passwords = new List<string>();
            this.rutAdmin = new List<int>();
            this.moneyAccumulate = new List<int>();
        }
        public void AddAccount(string account)
        {
            accounts.Add(account);

        }
        public void AddPassword(string password)
        {
            passwords.Add(password);
        }
        public void AddAdminName(int rut)
        {
            rutAdmin.Add(rut);

        }
        public void AddMoneyAcumulate(int balance)
        {
            moneyAccumulate.Add(balance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem_scratch
{
    internal class UserManagment
    {
        public void Register(string name)
        {
            Customer customer = new Customer 
            { 
            Name = name,
            };
            BankAccount Account = new BankAccount { Owner = customer };
            bankAccounts.Add(Account);
        }
    }
}

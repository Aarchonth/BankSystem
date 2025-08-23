using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem_scratch
{
    internal class BankAccount
    {
        public Customer Owner { get; set; }
        public string password { get; set; }
        public int balance { get; set; }
    }
}

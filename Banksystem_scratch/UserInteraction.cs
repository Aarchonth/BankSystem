using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem_scratch
{
    internal class UserInteraction
    {
        public static void HandlingRegister(UserManagment userManagment)
        {
            Console.WriteLine("Whats the Name of the Owner?");
            Console.WriteLine();
            string inputName = Console.ReadLine();             // Owner Name
            Console.WriteLine();
            Console.WriteLine($"ist der Besitzer {inputName}");
            Console.WriteLine("(y) or (n)");
            string nameConfirm = Console.ReadLine();            // Owner Right
            switch (nameConfirm)
            {
                case "y":
                    Console.WriteLine($"OWNER ({inputName}) was set");
                    while (true)
                    {
                        Console.WriteLine("Whats your choice of PASSWORD?");
                        Console.WriteLine();
                        string inputPassword = Console.ReadLine();             // Owner Password
                        Console.WriteLine();
                        Console.WriteLine($"is the PASSWORD {inputPassword}");
                        Console.WriteLine("(y) or (n)");
                        string passwordConfirm = Console.ReadLine();            // Password Right
                        switch (passwordConfirm)
                        {
                            case "y":
                              //  Account.password = o_p;
                              //  Console.WriteLine($"PASSWORD ({Account.password}) was set");
                              //  Console.WriteLine($"Your Account From ({Account.Owner.name})");
                                return;
                            case "n":
                                continue;
                        }
                    }
                case "n":           // erstes switch case
                    continue;
            }
        }
        public void ShowBalance(BankAccount Acc)
        {
            Console.WriteLine($"Your Balance is ({Acc.balance})");

        }
        static void Main()
        {
            Bank myBank = new Bank();
            while (true)
            {
                Console.WriteLine("\n1 - Create Account");
                Console.WriteLine("2 - Log In");
                Console.WriteLine("3 - Exit");
                string m_s = Console.ReadLine();          // Menu Select

                switch (m_s)
                {
                    case "1":
                        myBank.CreateAccount();
                        break;
                    case "2":
                        myBank.LogIn();
                        break;
                    case "3":
                        return;
                }
            }
        }
    }
}

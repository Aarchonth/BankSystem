using System.Security.Principal;

class Customer 
{
    public string name { get; set; }
}
class BankAccount
{
    public Customer Owner { get; set; }
    public string password { get; set; }
    public int balance { get; set; }
    
}
class Bank
{
    public List<BankAccount> bankAccounts { get; set; } = new List<BankAccount>();
    public void ShowBalance(BankAccount Acc)
    {
        Console.WriteLine($"Your Balance is ({Acc.balance})");

    }
    public void Deposit(BankAccount Acc)
    {
        Console.WriteLine("Enter amount to deposit:");
        string m_d = Console.ReadLine();
        int amount;

        if (int.TryParse(m_d, out amount) && amount > 0)
        {
            Acc.balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {Acc.balance}");
        }
        else 
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
    public void Withdraw(BankAccount Acc)
    {
        string m_w = Console.ReadLine();
        int amount;

        if (int.TryParse(m_w, out amount) && amount > 0)
        {
            if (Acc.balance >= amount)
            {
                Acc.balance -= amount;
                Console.WriteLine($"You withdrew {amount}. New balance: {Acc.balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
            
        }
        else 
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
        
    }

    public void CreateAccount()
    {
        while (true)
        {
            Console.WriteLine("Whats the Name of the Owner?");
            Console.WriteLine();
            string o_n = Console.ReadLine();             // Owner Name
            Console.WriteLine();
            Console.WriteLine($"ist der Besitzer {o_n}");
            Console.WriteLine("(y) or (n)");
            string o_r = Console.ReadLine();            // Owner Right
            switch (o_r)
            {
                case "y":
                    Customer customer = new Customer { name = o_n };
                    BankAccount Account = new BankAccount { Owner = customer };
                    Console.WriteLine($"OWNER ({o_n}) was set");
                    while (true)
                    {
                        Console.WriteLine("Whats your choice of PASSWORD?");
                        Console.WriteLine();
                        string o_p = Console.ReadLine();             // Owner Password
                        Console.WriteLine();
                        Console.WriteLine($"is the PASSWORD {o_p}");
                        Console.WriteLine("(y) or (n)");
                        string p_r = Console.ReadLine();            // Password Right
                        switch (p_r)
                        {
                            case "y":
                                Account.password = o_p;
                                Console.WriteLine($"PASSWORD ({Account.password}) was set");
                                bankAccounts.Add(Account);
                                Console.WriteLine($"Your Account From ({Account.Owner.name})");
                                return;
                            case "n":
                                continue;
                        }
                    }
                case "n":           // erstes switch case
                    continue;
            }
        }
    }
    public void LogIn()
    {
        Console.WriteLine("Enter your name:");
        string inputName = Console.ReadLine();

        Console.WriteLine("Enter your password:");
        string inputPassword = Console.ReadLine();

        bool found = false;
        foreach (BankAccount Acc in bankAccounts)
        {
            if (inputName == Acc.Owner.name && Acc.password == inputPassword)
            {
                found = true;
                Console.WriteLine("\n1 - Show Balance");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Logout");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        ShowBalance(Acc);
                        break;
                    case "2":
                        Deposit(Acc);
                        break;
                    case "3":
                        Withdraw(Acc);
                        break;
                    case "4":
                        return;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("There is no Account Like that");
            Console.WriteLine("Try again");
        }
    }

    class Program
    {
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class BankAccount
    {
        private string accountName;
        private double balance;

        public BankAccount(string name, double bal)
        {
            accountName = name;
            balance = bal;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void UpdateBalance(double amount)
        {
            balance += amount;
        }

        public string GetName()
        {
            return accountName;
        }
    }

    class BankTransaction
    {
        // Transfer without message
        public void Transfer(BankAccount from, BankAccount to, double amount)
        {
            if (amount <= 0 || from.GetBalance() < amount)
                throw new Exception("Invalid transfer amount");

            from.UpdateBalance(-amount);
            to.UpdateBalance(amount);

            Console.WriteLine("Transfer Successful");
        }

        // Overloaded Transfer with message
        public void Transfer(BankAccount from, BankAccount to, double amount, string message)
        {
            Transfer(from, to, amount);
            Console.WriteLine("Message: " + message);
        }
    }
}

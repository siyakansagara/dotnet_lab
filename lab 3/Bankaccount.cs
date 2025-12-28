using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bankaccount
    {
        public int accountName;
        public int holdername;
        public int balance;

        public Bankaccount(int accountName, int holdername ,int balance)
        {
            this.accountName = accountName;
            this.holdername = holdername;
            this.balance = balance;
        }
        public void deposite(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Can not deposite");
            }
            else
            {
               
            }
        }
    }
}

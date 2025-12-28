using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    abstract class Payment
    {
        abstract public void MakePayment(double amount);
    }
    class CreditCardPayment: Payment
    {
        public override void MakePayment(double amount)
        {
            if (amount < 100)
            {
                throw new Exception("Payment failed: Amount must be at least ₹100.");
            }
            Console.WriteLine($"Credit Card payment of ₹{amount} successful.");
        }
    }
    class UPIPayment : Payment
    {
        public override void MakePayment(double amount)
        {
            if (amount < 100)
            {
                throw new Exception("Payment failed: Amount must be at least ₹100.");
            }
            Console.WriteLine($"UPI payment of ₹{amount} successful.");
        }
    }
}

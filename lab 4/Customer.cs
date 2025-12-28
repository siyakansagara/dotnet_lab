using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Customer
    {
        protected double amount;

        public Customer(double amt)
        {
            amount = amt;
        }

        public virtual double CalculateBill()
        {
            return amount;
        }
    }

    class RegularCustomer : Customer
    {
        public RegularCustomer(double amt) : base(amt) { }

        public override double CalculateBill()
        {
            return amount - (amount * 0.05); // 5% discount
        }
    }

    class PremiumCustomer : Customer
    {
        public PremiumCustomer(double amt) : base(amt) { }

        public override double CalculateBill()
        {
            return amount - (amount * 0.15); // 15% discount
        }
    }
}

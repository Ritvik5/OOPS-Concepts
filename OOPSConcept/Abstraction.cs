using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // -- Abstraction is achived though abstract keyword

    public abstract class Customer1
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public decimal productAmount { get; set; }
        public abstract decimal CalculateDiscount();

        public abstract string GreetingMessage();
    }

    public class SadCustomer : Customer1
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 10;
        }

        public override string GreetingMessage()
        {
            return "Thank You ;-) ";
        }
    }

    public class HappyCustomer : Customer1
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 20;
        }

        public override string GreetingMessage()
        {
            return " Thank you. Visit again.";
        }
    }
}

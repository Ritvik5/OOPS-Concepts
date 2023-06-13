using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // -- Single Level Inheritance
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
    }

    // -- MultiLevel Inheritance

    public class Manager : Employee
    {
        public int ManagerId { get; set; }

    }

    // -- Hierarchical Inheritance
    public class Supervisor : Person
    {
        private int SupervisorId;

        public int GetSupervisorId
        {
            get { return SupervisorId; }
            set { SupervisorId = value; }
        }
    }

    // -- Multiple Inheritance using interface

    public interface ICustomer
    {
        string Name { get; set; }
        string Address { get; set; }

        decimal productAmount { get; set; }

        decimal CalculateDiscount();
    }

    public interface ICustomerGreeting : ICustomer
    {
        string GreetingMessage();
    }

    public abstract class Customer : ICustomer, ICustomerGreeting
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public decimal productAmount { get; set; }
        public abstract decimal CalculateDiscount();

        public abstract string GreetingMessage();
    }

    public class GoldCustomer : Customer
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

    public class SilverCustomer : Customer
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

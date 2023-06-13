using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{

    // By Method Overridng
    public class Company
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public decimal ProductAmount { get; set; }

        public virtual decimal CalculateDiscount()
        {
            return ProductAmount;
            
        }
    }

    public class Employees : Company
    {
        public override decimal CalculateDiscount()
        {
            return ProductAmount - 10;
        }
    }

    public class Managers : Company
    {
        public override decimal CalculateDiscount()
        {
            return ProductAmount - 20;
        }
    }

    // By method OverLoading
    
    public class Hospital
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public decimal Salary { get; set; }

        public decimal TotalSalary()
        {
            return Salary;
        }
        public decimal TotalSalary(decimal nurseIncentive)
        {
            return Salary + nurseIncentive;
        }

        public decimal TotalSalary(decimal doctorIncentive, decimal leaves)
        {
            return Salary + doctorIncentive - leaves;
        }

    }
}

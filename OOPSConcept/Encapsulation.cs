using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Patient
    {
        private string Name { get; set; }

        private string Address { get; set; }

        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string GetAddress
        {
            get { return Address; }
            set { Address = value; }
        }
    }

    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Funds..");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}

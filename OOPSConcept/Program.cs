namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Object Oriented Programing!!!\n");
            //Patient patient = new Patient();
            //patient.GetName = "Ajay";
            //patient.GetAddress = "127.0.0.1";

            //Console.WriteLine("Name of the Patient is: " + patient.GetName + " and Address is: " + patient.GetAddress + "\n");

            //BankAccount obj = new BankAccount(1000);
            //obj.Deposit(2000);

            //Console.WriteLine("Balance after deposit is: " + obj.GetBalance() + "\n");

            //obj.Withdraw(500);
            //Console.WriteLine("Balance after withdraw is: " + obj.GetBalance());

            /* Inheritansce -- Derived class has all the properties , methods of the parent class */

            // -- Single Level Inheritance

            Employee employee = new Employee();
            employee.FirstName = "Ankur";
            employee.LastName = "Bhardhwaj";
            employee.EmployeeId = 1;
            employee.CompanyName = "Radha Textiles";
            Console.WriteLine("Employee Full Name is " + employee.FirstName + " " + employee.LastName +
                            " and employee ID is " + employee.EmployeeId + " for the company " + employee.CompanyName + ".\n");

            Console.Read();
        }
    }
}
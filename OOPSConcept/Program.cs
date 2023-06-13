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

            //Employee employee = new Employee();
            //employee.FirstName = "Ankur";
            //employee.LastName = "Bhardhwaj";
            //employee.EmployeeId = 1;
            //employee.CompanyName = "Radha Textiles";
            //Console.WriteLine("Employee Full Name is " + employee.FirstName + " " + employee.LastName +
            //                " and employee ID is " + employee.EmployeeId + " for the company " + employee.CompanyName + ".\n");

            // --Multi Level Inheritance

            //Manager manager = new Manager();

            //manager.FirstName = "Saurav";
            //manager.LastName = "Chaudhary";

            //manager.CompanyName = "Radha Textiles";
            //manager.ManagerId = 100;

            //Console.WriteLine("Manager Full Name is " + manager.GetFullName() + " and mangerID is " +
            //                    manager.ManagerId + " for the company " + manager.CompanyName + "\n");

            //// -- Hierarchical Interface

            //Supervisor supervisor = new Supervisor();
            //supervisor.GetSupervisorId = 25;
            //supervisor.FirstName = "Rishi";
            //supervisor.LastName = "Kapoor";
            //Console.WriteLine("Supervisor id is: " + supervisor.GetSupervisorId + " and full name is " + supervisor.GetFullName()+"\n");


            //// Interface implemnetation (multiple inheritance)

            //GoldCustomer obj = new GoldCustomer();
            //obj.Name = "Ramesh";
            //obj.Address = "Bangalore";
            //obj.productAmount = 100;


            //Console.WriteLine("Name = " + obj.Name + "\nAddress = " + obj.Address + "\nProductAmount = " + obj.productAmount +
            //                            "\nProductAmount after discount = " + obj.CalculateDiscount() + "\nGreetingMessage = " + obj.GreetingMessage());

            //SilverCustomer obj2 = new SilverCustomer();
            //obj2.Name = "Suresh";
            //obj2.Address = "Bangalore";
            //obj2.productAmount = 100;
            //Console.WriteLine("\nName = " + obj2.Name + "\nAddress = " + obj2.Address + "\nProductAmount = " + obj2.productAmount +
            //                            "\nProductAmount after discount = " + obj2.CalculateDiscount() + "\nGreetingMessage = " + obj2.GreetingMessage());

            //Console.Read();

            // Abstraction

            //SadCustomer obj1 = new SadCustomer();
            //obj1.Name = "Sumit";
            //obj1.Address = "Bangalore";
            //obj1.productAmount = 100;

            //Console.WriteLine("Name = " + obj1.Name + "\nAddress = " + obj1.Address + "\nProductAmount = " + obj1.productAmount +
            //                            "\nProductAmount after discount = " + obj1.CalculateDiscount() + "\nGreetingMessage = " + obj1.GreetingMessage());

            //HappyCustomer obj2 = new HappyCustomer();
            //obj2.Name = "Suresh";
            //obj2.Address = "Bangalore";
            //obj2.productAmount = 100;
            //Console.WriteLine("\nName = " + obj2.Name + "\nAddress = " + obj2.Address + "\nProductAmount = " + obj2.productAmount +
            //                            "\nProductAmount after discount = " + obj2.CalculateDiscount() + "\nGreetingMessage = " + obj2.GreetingMessage());

            // -- Polymorphism by method overriding


            //Company com = new Employees();
            //com = new Managers();

            // object having more than one form here.

            Company com = new Employees();
            com.Name = "Rahul";
            com.Address = "Bangalore";
            com.ProductAmount = 100;

            Console.WriteLine("Emp Name = "+com.Name+"\nEmp Address = "+com.Address+"\nCompany Product Amount = "+com.ProductAmount
                +"\nProduct Amount After distcount = "+com.CalculateDiscount()+"\n");

            Company man = new Managers();
            man.Name = "Rituraj";
            man.Address = "Bangalore";
            man.ProductAmount = 100;

            Console.WriteLine("Emp Name = " + man.Name + "\nEmp Address = " + man.Address + "\nCompany Product Amount = " + man.ProductAmount
                + "\nProduct Amount After distcount = " + man.CalculateDiscount());

            Hospital obj = new Hospital();
            obj.Salary = 100;

            Console.WriteLine("\nTotal Salary for Nurse is "+obj.TotalSalary(100)+"\nTotal Salary for Doctor is : "+obj.TotalSalary(100,50));
        }
    }
}
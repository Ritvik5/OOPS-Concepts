namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Object Oriented Programing!!!\n");
            Patient patient = new Patient();
            patient.GetName = "Ajay";
            patient.GetAddress = "127.0.0.1";

            Console.WriteLine("Name of the Patient is: " + patient.GetName + " and Address is: " + patient.GetAddress + "\n");

            BankAccount obj = new BankAccount(1000);
            obj.Deposit(2000);

            Console.WriteLine("Balance after deposit is: " + obj.GetBalance() + "\n");

            obj.Withdraw(500);
            Console.WriteLine("Balance after withdraw is: " + obj.GetBalance());
            Console.Read();
        }
    }
}
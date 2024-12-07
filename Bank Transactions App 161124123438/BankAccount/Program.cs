using System.Transactions;

namespace BankAccount //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here

            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("Enter the choice");    
            
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Account Number");
            string accountNumber = Console.ReadLine();
            Console.WriteLine("Enter the balance");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            


            Account account = new Account()
            {


                AccountNumber = accountNumber,
                Balance = balance,
                //amount1 = amount

            };

            if (choice == 1)
            {
                Console.WriteLine("Enter the amount to be deposit");
                decimal amount1 = Convert.ToDecimal(Console.ReadLine());
                decimal balanceAmount = account.Deposit(amount1);
                Console.WriteLine($"Balance amount: {balanceAmount}");


            }
            else if (choice == 2)
            {

                Console.WriteLine("Enter the amount to be withdraw");
                decimal amount2 = Convert.ToDecimal(Console.ReadLine());
                decimal balanceAmount = account.Withdraw(amount2);
                Console.WriteLine($"Balance amount: {balanceAmount}");
            }

            else {

                Console.WriteLine("Invalid input");
            }
        }
    }
}

namespace BankAccount //DO NOT change the namespace name
{
    public class Account //DO NOT change the class name
    {
        //Implement your code here
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public decimal Deposit(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {

                    throw new ArgumentException("Deposit amount must be positive.");

                }

                Balance += amount;
                return Balance;
            }

            catch (ArgumentException ex) { 
            
                Console.WriteLine(ex.Message);
                return Balance;
            }

        }

        public decimal Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {

                    throw new ArgumentException("Withdrawal amount must be positive.");
                }

                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds");


                }

                Balance -= amount;
                return Balance;
            }



            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return Balance;
            }

            catch (InvalidOperationException ex) { 
            
                Console.WriteLine(ex.Message);
                return Balance;
            }

        }
    }
}
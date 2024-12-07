using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenLedger  //DO NOT change the namespace name
{
    public class Program  //DO NOT change the class name
    {
        public static void Main(string[] args) //DO NOT change the 'Main' method signature
        {
            //Implement your code here
            Console.WriteLine("Entyer the gold item name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the number of stocks");
            int stock = int.Parse(Console.ReadLine());


           GoldItem goldItem = new GoldItem()
            {
                Name = name,
                Stock = stock
            };

            InventoryService s = new InventoryService();
            try
            {
                if (s.PlaceOrder(goldItem))
                {
                    Console.WriteLine("Order placed successfully");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

        }
    }
}
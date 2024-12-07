using System.Diagnostics;
using System.Drawing;

namespace InfantCouture   //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>();

        public static void Main(string[] args) //DO NOT change the 'Main' method signature
        {
            //Implement your code here
            //BabyDress babyDress = new BabyDress();
            Console.WriteLine("1. Add dress to cart");
            Console.WriteLine("2.Remove dress from cart");
            Console.WriteLine("3.Exit");
            int choice = int.Parse(Console.ReadLine());



            if (choice == 1)
            {

                Console.WriteLine("Enter the dress size");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the dress color");
                string color = Console.ReadLine();
                Console.WriteLine("Enter the dress brand");
                string brand = Console.ReadLine();
                Console.WriteLine("Enter the dress price");
                double price = double.Parse(Console.ReadLine());
                BabyDress babyDress = new BabyDress()
                {
                    Size = size,
                    Color = color,
                    Brand = brand,
                    Price = price
                };


                BabyDressUtility bt = new BabyDressUtility();
                bt.AddDressToCart(babyDress);
                
                Console.WriteLine("Successfully added to the dress cart");



            }
            else if (choice == 2)
            {

                Console.WriteLine("Enter the dress brand to remove from cart");

                string brand = Console.ReadLine();
                BabyDress babyDress = new BabyDress()
                {

                    Brand = brand,

                };
                BabyDressUtility b = new BabyDressUtility();


                if (b.RemoveDressFromCart(brand))
                {
                    Console.WriteLine("Successfully removed from the cart");
                }
                else
                {

                    Console.WriteLine("Dress not found in thge cart");

                }
            }
            else if (choice == 3) {

                Console.WriteLine("Thank you!");
            }

        }
    }
}



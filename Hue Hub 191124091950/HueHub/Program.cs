namespace HueHub   //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        public static Dictionary<string, Color> ColorInventory { get; set; } = new Dictionary<string, Color>();

        public static void Main(string[] args) //DO NOT change the 'Main' method signature
        {
            //Implement your code here
            Console.WriteLine("1.Add color to inventry");
            Console.WriteLine("2.Remove color from inventry");
            Console.WriteLine("3.Exit");
            int choice = int.Parse(Console.ReadLine());
            while (true)
            {
                if (choice == 1)
                {
                    Console.WriteLine("Enter color name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter hex code");
                    string hexCode = Console.ReadLine();
                    Console.WriteLine("Enter price per liter");
                    double pricePerLiter = double.Parse(Console.ReadLine());

                    Color c = new Color()
                    {
                        Name = name,
                        HexCode = hexCode,
                        PricePerLiter = pricePerLiter

                    };

                    ColorUtility U = new ColorUtility();
                    U.AddColor(name, hexCode, pricePerLiter);
                    Console.WriteLine($"Added {name} color to inventory");
                }
                else if (choice == 2)
                {
                    ColorUtility U = new ColorUtility();
                    Console.WriteLine("Enter color name to remove:");
                    string name = Console.ReadLine();
                    Color c = new Color()
                    {
                        Name = name
                    };

                    //bool removed = U.RemoveColor(name);
                    if (U.RemoveColor(name))
                    {




                        //ColorUtility U = new ColorUtility();
                        //U.RemoveColor(name);
                        Console.WriteLine($"Removed {name} color from inventory");

                    }
                    else
                    {
                        Console.WriteLine($"Color {name} not found in inventory");
                    }



                }
                else if (choice == 3)
                {

                    Console.WriteLine("Exiting Color Management System");
                    break;
                }
                
            }

        }
    }
}



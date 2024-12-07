using System.Runtime.CompilerServices;

namespace HueHub   //DO NOT change the namespace name
{
    public class ColorUtility    //DO NOT change the class name
    {
        //Implement your code here 
        public void AddColor(string name, string hexCode, double pricePerLiter)
        {
            Color c = new Color()
            {
                Name = name,
                HexCode = hexCode,
                PricePerLiter = pricePerLiter
            };
            Program.ColorInventory.Add(name, c);
        }
        public bool RemoveColor(string name) {
            if (Program.ColorInventory.ContainsKey(name))
            {
                Program.ColorInventory.Remove(name);
                return true;
            } 
            return false;
                    
        }


    }

    
}
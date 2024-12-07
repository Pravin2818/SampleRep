namespace InfantCouture   //DO NOT change the namespace name
{
    public class BabyDressUtility    //DO NOT change the class name
    {
        //Implement your code here
        public void AddDressToCart(BabyDress dress)
        {
            Program.DressesCart.Add(dress);
        }
        public bool RemoveDressFromCart(string brand)
        {


            foreach (var dress in Program.DressesCart)
               {
                 if ((dress.Brand == brand))
                 {
                     Program.DressesCart.Remove(dress);
                 }
                    return true;

               }
            return false;
            

            
        }
    }
}
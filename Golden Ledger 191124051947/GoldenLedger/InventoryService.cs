namespace GoldenLedger   //DO NOT change the namespace name
{
    public class InventoryService    //DO NOT change the class name
    {
        //Implement your code here 
        public bool PlaceOrder(GoldItem goldItem)
        {
            if(goldItem.Stock <= 0)
            {
                throw new GoldItemOutOfStockException("Gold item is out of stock");
            }
            if (goldItem.Stock > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
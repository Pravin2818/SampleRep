namespace GoldenLedger   //DO NOT change the namespace name
{
    public class GoldItemOutOfStockException : Exception    //DO NOT change the class name
    {
        //Implement your code here 
        public GoldItemOutOfStockException(string message) : base(message) { }
    }
}
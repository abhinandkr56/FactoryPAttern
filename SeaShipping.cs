public class SeaShipping : IShippingType
{
  public void ProcessShipping()
  {
    Console.WriteLine("Sea shipping processed");
  }

  public void ShipOrder()
  {
    Console.WriteLine("Sea Shipping done");
  }
}
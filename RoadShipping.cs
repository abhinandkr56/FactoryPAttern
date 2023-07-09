public class RoadShipping : IShippingType
{
  public void ProcessShipping()
  {
    Console.WriteLine("Road shipping processed");
  }

  public void ShipOrder()
  {
    Console.WriteLine("Road Shipping done");
  }
}
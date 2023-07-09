public class SeaShippingCreator : Creator
{
  public override IShippingType Factory()
  {
    return new SeaShipping();
  }
}
public class RoadShippingCreator : Creator
{
  public override IShippingType Factory()
  {
    return new RoadShipping();
  }
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Ship(new SeaShippingCreator());

Ship(new RoadShippingCreator());

void Ship(Creator creator){
  
  var ship = creator.Factory();
  ship.ProcessShipping();
  ship.ShipOrder();
}
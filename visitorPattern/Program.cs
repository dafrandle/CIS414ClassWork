using visitorPattern;
CarClass pickup = new CarBuilder(new DieselPickup()).CreateCar();
CarClass sedan = new CarBuilder(new ElectricSedan()).CreateCar();

Console.WriteLine("Truck:");
Console.WriteLine("---------------");
Console.WriteLine(pickup.ToString());
Console.WriteLine("---------------");
Console.WriteLine($"Max Range: {new RangeVisitor().Visit(pickup)} miles");
Console.WriteLine($"0 to 60 time: {new TimeTo60Visitor().Visit(pickup)} seconds");
Console.WriteLine($"Load Capacity: {new LoadCapacityVisitor().Visit(pickup)} kg");
Console.WriteLine("===========================================");
Console.WriteLine("Sedan:");
Console.WriteLine("---------------");
Console.WriteLine(sedan.ToString());
Console.WriteLine("---------------");
Console.WriteLine($"Max Range: {new RangeVisitor().Visit(sedan)} miles");
Console.WriteLine($"0 to 60 time: {new TimeTo60Visitor().Visit(sedan)} seconds");
Console.WriteLine($"Load Capacity: {new LoadCapacityVisitor().Visit(sedan)} kg");

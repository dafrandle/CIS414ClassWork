using builderInterface;
Director director = new("Electric Sedan");
CarClass car = director.BuildCar();

director.Choice = "Diesel Pickup";
CarClass truck =  director.BuildCar();

Console.WriteLine(car.Description());
Console.WriteLine("----------------------------------");
Console.WriteLine(truck.Description());
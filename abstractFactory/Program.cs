using abstractFactory;
IVehicleFactory factory = new PassengerFactory();

GroundVehicleClass groundVehicle = factory.CreateGroundVehicle();
AircraftClass aircraft = factory.CreateAircraft();

Console.WriteLine(groundVehicle.ToString());
Console.WriteLine("--------------------");
Console.WriteLine(aircraft.ToString());
Console.WriteLine("--------------------");
Console.WriteLine("--------------------");


factory = new CargoFactory();

GroundVehicleClass cargoVehicle = factory.CreateGroundVehicle();
AircraftClass cargoAircraft = factory.CreateAircraft();

Console.WriteLine(cargoVehicle.ToString());
Console.WriteLine("--------------------");
Console.WriteLine(cargoAircraft.ToString());
Console.WriteLine("--------------------");
Console.WriteLine("--------------------");



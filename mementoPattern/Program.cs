using mementoPattern;
CarOriginator originator = new(new CarBuilder(new DieselPickup()).CreateCar());
Caretaker caretaker = new();
Console.WriteLine("Create originator with Diesel Pickup");

caretaker.AddMemento(originator.CreateMemento());
Console.WriteLine("Add memento to caretaker");
Console.WriteLine(caretaker.GetMementoCount());

originator.Car.Name = "DeLorean DMC-12";
originator.Car.Size = "2 Door Sports Car";
originator.Car.Engine = "Rear-mounted; liquid-cooled; twin-turbocharged; 1.21 gigawatt nuclear fusion reactor";
originator.Car.CenterConsole = "Time circuits";
originator.Car.CruiseControl = "No Cruise Control";
originator.Car.Doors = "Butterfly Doors";
originator.Car.EnergyType = "Plutonium";
originator.Car.EnergyCapacity = 1;
originator.Car.MilesPerEnergyUnit = 100000;
originator.Car.AccelerationMSsquared = 4;
originator.Car.WeightInKG = 1235;
originator.Car.GVWRInKG = 1600;

caretaker.AddMemento(originator.CreateMemento());
Console.WriteLine("Add memento to caretaker");
Console.WriteLine(caretaker.GetMementoCount());

originator.Car.Name = "Ecto-1";
originator.Car.Size = "Hearse";
originator.Car.Engine = "454 cu. in. V8";
originator.Car.CenterConsole = "AM/FM radio with 8-track player, PKE meter";
originator.Car.CruiseControl = "Normal Cruise Control";
originator.Car.Doors = "Normal Doors";
originator.Car.EnergyType = "Gallons";
originator.Car.EnergyCapacity = 20;
originator.Car.MilesPerEnergyUnit = 11;
originator.Car.AccelerationMSsquared = 6;
originator.Car.WeightInKG = 7000;
originator.Car.GVWRInKG = 10000;

caretaker.AddMemento(originator.CreateMemento());
Console.WriteLine("Add memento to caretaker");
Console.WriteLine(caretaker.GetMementoCount());
Console.WriteLine("----------------");
Console.WriteLine(originator.Car.ToString());
Console.WriteLine("----------------");
Console.WriteLine("Undo memento to beginning");
caretaker.UndoMementoToIndex(0);
Console.WriteLine(caretaker.GetMementoCount());
Console.WriteLine("----------------");
Console.WriteLine(originator.Car.ToString());
Console.WriteLine("----------------");





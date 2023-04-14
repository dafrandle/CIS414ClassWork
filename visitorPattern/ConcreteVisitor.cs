namespace visitorPattern
{
    internal class ConcreteVisitor : ICarVisitor
    {
        public double Range { get; set; }
        public double TimeTo60 { get; set; }
        public double LoadCapacity { get; set; }

        public void Visits(CarClass car)
        {
            Range = car.EnergyCapacity * car.MilesPerEnergyUnit;
            TimeTo60 = 60 / (car.AccelerationMSsquared * 2.24);
            LoadCapacity = car.GVWRInKG - car.WeightInKG;
        }
    }
}

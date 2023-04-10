namespace visitorPattern
{
    internal class RangeVisitor : ICarVisitor<double>
    {
        public double Visit(CarClass car)
        {
            return car.EnergyCapacity * car.MilesPerEnergyUnit;
        }
    }
}

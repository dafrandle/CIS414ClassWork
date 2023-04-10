namespace visitorPattern
{
    internal class LoadCapacityVisitor : ICarVisitor<double>
    {
        public double Visit(CarClass car)
        {
            return car.GVWRInKG - car.WeightInKG;
        }
    }
}

namespace visitorPattern
{
    internal class TimeTo60Visitor : ICarVisitor<double>
    {
        public double Visit(CarClass car)
        {
            return 60/(car.AccelerationMSsquared*2.24);
        }
    }
}

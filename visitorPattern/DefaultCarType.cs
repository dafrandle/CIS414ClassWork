namespace visitorPattern
{
    internal class DefaultCarType : ICarType
    {
        public CarClass Create()
        {
            CarClass car = new();
            return car;
        }

    }
}

namespace mementoPattern
{
    internal class CarBuilder
    {
        private ICarType choice = new DefaultCarType();

        public ICarType Choice { get => choice; set => choice = value; }

        public CarBuilder()
        {
            Choice = new DefaultCarType();
        }

        public CarBuilder(ICarType choice)
        {
            Choice = choice;
        }

        public CarClass CreateCar()
        {
            return Choice.Create();
        }
    }
}

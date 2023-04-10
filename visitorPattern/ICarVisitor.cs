namespace visitorPattern
{
    internal interface ICarVisitor<T>
    {
        T Visit(CarClass car);
    }
}

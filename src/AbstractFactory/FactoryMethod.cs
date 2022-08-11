namespace AbstractFactory
{
    public interface IMassaFactoryMethod
    {
        MassaBase CriaMassa(Enum massaFactoryType);
    }
}

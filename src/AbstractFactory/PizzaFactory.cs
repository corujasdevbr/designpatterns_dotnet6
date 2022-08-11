namespace AbstractFactory
{
    public sealed class PizzaFactory : IMassaFactoryMethod
    {
        public MassaBase CriaMassa(Enum massaFactoryType)
        {
            var tipoPizza = (TipoPizza)massaFactoryType;

            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                    {
                        return new PizzaMussarela();
                    }
                case TipoPizza.Calabreza:
                    {
                        return new PizzaCalabreza();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}

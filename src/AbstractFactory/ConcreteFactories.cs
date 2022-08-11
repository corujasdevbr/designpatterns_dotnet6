namespace AbstractFactory
{
    //ProductB1
    public sealed class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza() : base("Pizza Calabreza", TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabreza em cubos e tomates em cubos");
        }
    }
    //ProductB2
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza Mussarela", TipoMassa.Pizza)
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
    //ProductA1
    public sealed class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo de Chocolate", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }
    }
    //ProductA2
    public sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}

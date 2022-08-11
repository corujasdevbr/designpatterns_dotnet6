namespace FactoryMethod
{
    public class Bauru : Product
    {
        private readonly string _nomeLanche;
        public Bauru()
        {
            _nomeLanche = "Bauru";
            Ingredientes.Add("Pão Francês");
            Ingredientes.Add("Presunto");
            Ingredientes.Add("Mussarela");
            Ingredientes.Add("Tomate e maionese");
        }
        public override string Nome { get => _nomeLanche; }
    }

    public class Frango : Product
    {
        private readonly string _nomeLanche;
        public Frango()
        {
            _nomeLanche = "Lanche de Frango";
            Ingredientes.Add("Peito de frango");
            Ingredientes.Add("Maionese e tomate");
        }
        public override string Nome { get => _nomeLanche; }
    }

    public class MistoQuente : Product
    {
        private readonly string _nomeLanche;
        public MistoQuente()
        {
            _nomeLanche = "Misto Quente";
            Ingredientes.Add("Pão Francês");
            Ingredientes.Add("Presunto e Mussarela na chapa");
        }
        public override string Nome { get => _nomeLanche; }
    }

    public class Vegetariano : Product
    {
        private readonly string _nomeLanche;
        public Vegetariano()
        {
            _nomeLanche = "Lanche Vegetariano";
            Ingredientes.Add("Alface e Rúcula ");
            Ingredientes.Add("Ervilha e Tomate");
        }
        public override string Nome { get => _nomeLanche; }
    }
}

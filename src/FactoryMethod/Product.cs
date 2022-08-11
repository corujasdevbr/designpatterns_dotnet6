using System.Collections;

namespace FactoryMethod
{
    public abstract class Product
    {
        public abstract string Nome { get; }
        public ArrayList Ingredientes = new ArrayList();
    }
}

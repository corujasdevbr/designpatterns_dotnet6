using System.Collections;

namespace AbstractFactory
{
    public abstract class MassaBase
    {
        public TipoMassa TipoMassa { get; set; }
        public string Nome { get; set; }

        public ArrayList Ingredientes = new ArrayList();

        public MassaBase(string nome, TipoMassa tipo)
        {
            Nome = nome;
            TipoMassa = tipo;
        }
    }
}

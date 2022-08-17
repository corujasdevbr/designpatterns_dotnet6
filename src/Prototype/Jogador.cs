using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Jogador : ICloneable
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public Chuteira Chuteira { get; set; }
        public object Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                this.Chuteira = (Chuteira)Chuteira.Clone(deepClone);
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Jogador>(objectAsJson);
            }

            Jogador jogador = (Jogador)MemberwiseClone();
            jogador.Chuteira = (Chuteira)Chuteira.Clone();
            return jogador;
        }

        public override string ToString()
        {
            return $"{Nome} - {Posicao} - {Chuteira.Nome} - {Chuteira.Numero}";
        }
    }
}

using Newtonsoft.Json;

namespace Prototype
{
    public class Chuteira : ICloneable
    {
        public string Nome { get; set; }
        public int Numero { get; set; }

        public object Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Chuteira>(objectAsJson);
            }

            return (Chuteira)MemberwiseClone();
        }
    }
}
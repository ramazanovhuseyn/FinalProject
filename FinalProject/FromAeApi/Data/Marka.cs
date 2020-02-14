using System.Collections.Generic;

namespace FromAeApi.Data
{
    public class Marka
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}

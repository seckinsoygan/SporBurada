using Entities.Abstract;

namespace Entities.Concrete
{
    public class Program : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int RecommendedDay { get; set; }
    }
}

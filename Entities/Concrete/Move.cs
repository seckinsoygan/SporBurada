using Entities.Abstract;

namespace Entities.Concrete
{
    public class Move : IEntity
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public string? Name { get; set; }
        public int RecommendedSet { get; set; }
        public int RecommendedRep { get; set; }
    }
}

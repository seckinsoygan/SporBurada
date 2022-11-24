using Entities.Abstract;

namespace Entities.Concrete
{
    public class Part : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}

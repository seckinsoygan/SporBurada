using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IPartDal
    {
        List<Part> GetAll();
        void Add(Part part);
        void Update(Part part);
        void Delete(Part part);
    }
}

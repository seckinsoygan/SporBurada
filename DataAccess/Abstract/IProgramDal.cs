using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProgramDal
    {
        List<Program> GetAll();
        void Add(Program program);
        void Update(Program program);
        void Delete(Program program);
    }
}

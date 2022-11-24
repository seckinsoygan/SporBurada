using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IMoveDal
    {
        List<Move> GetAll();
        void Add(Move move);
        void Update(Move move);
        void Delete(Move move);
    }
}

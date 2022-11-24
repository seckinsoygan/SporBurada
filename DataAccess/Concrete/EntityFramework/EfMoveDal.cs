using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMoveDal : IMoveDal
    {
        public void Add(Move entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Move entity)
        {
            throw new NotImplementedException();
        }

        public Move Get(Expression<Func<Move, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Move> GetAll(Expression<Func<Move, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Move entity)
        {
            throw new NotImplementedException();
        }
    }
}

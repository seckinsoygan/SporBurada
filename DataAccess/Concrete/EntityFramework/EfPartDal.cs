using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPartDal : IPartDal
    {
        public void Add(Part entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Part entity)
        {
            throw new NotImplementedException();
        }

        public Part Get(Expression<Func<Part, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Part> GetAll(Expression<Func<Part, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Part entity)
        {
            throw new NotImplementedException();
        }
    }
}

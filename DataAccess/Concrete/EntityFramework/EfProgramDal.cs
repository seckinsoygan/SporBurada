using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProgramDal : IProgramDal
    {
        public void Add(Program entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Program entity)
        {
            throw new NotImplementedException();
        }

        public Program Get(Expression<Func<Program, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Program> GetAll(Expression<Func<Program, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Program entity)
        {
            throw new NotImplementedException();
        }
    }
}

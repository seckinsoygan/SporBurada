using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProgramDal : IProgramDal
    {
        DbContext _dbContext;
        public void Add(Program entity)
        {
            using (SportHereContext sportHereContext = new SportHereContext())
            {
                var addedEntity = sportHereContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                sportHereContext.SaveChanges();
            }
        }

        public void Delete(Program entity)
        {
            using (SportHereContext sportHereContext = new SportHereContext())
            {
                var deletedEntity = sportHereContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                sportHereContext.SaveChanges();
            }
        }

        public Program Get(Expression<Func<Program, bool>> filter)
        {
            using (SportHereContext sportHereContext = new SportHereContext())
            {
                return sportHereContext.Set<Program>().SingleOrDefault();
            }
        }

        public List<Program> GetAll(Expression<Func<Program, bool>> filter = null)
        {
            using (SportHereContext sportHereContext = new SportHereContext())
            {
                return filter == null ? sportHereContext.Set<Program>().ToList() : sportHereContext.Set<Program>().Where(filter).ToList();
            }
        }

        public void Update(Program entity)
        {
            using (SportHereContext sportHereContext = new SportHereContext())
            {
                var updatedEntity = sportHereContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                sportHereContext.SaveChanges();
            }
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProgramManager : IProgramService
    {
        IProgramDal _programDal;

        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }

        public List<Program> GetAll()
        {
            return _programDal.GetAll();
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PartManager : IPartService
    {
        IPartDal _partDal;

        public PartManager(IPartDal partDal)
        {
            _partDal = partDal;
        }

        public List<Part> GetAll()
        {
            return _partDal.GetAll();
        }
    }
}

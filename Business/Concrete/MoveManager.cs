using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MoveManager : IMoveService
    {
        IMoveDal _moveDal;

        public MoveManager(IMoveDal moveDal)
        {
            _moveDal = moveDal;
        }

        public List<Move> GetAll()
        {
            return _moveDal.GetAll();
        }
    }
}

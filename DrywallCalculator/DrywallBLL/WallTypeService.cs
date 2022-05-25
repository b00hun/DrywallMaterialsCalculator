using DrywallDB.Repository;
using DrywallModels.Models;

namespace DrywallBLL
{
    public class WallTypeService : IWallTypeService
    {
        private readonly IWallTypeRepository _repository;

        public WallTypeService(IWallTypeRepository repository)
        {
            _repository = repository;

        }

        public WallType GetById(int id)
        {
            var wallType = _repository.GetById(id);
            return wallType;
        }
        public List<WallType> GetAll()
        {
            return _repository.GetAllData();
        }

        public void Create(WallType wallType)
        {
            _repository.Create(wallType);
        }

        public void Update(WallType wallType)
        {
            _repository.Update(wallType);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
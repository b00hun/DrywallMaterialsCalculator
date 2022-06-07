using DrywallDB.Repository;
using DrywallModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallBLL
{
    public class DrywallService : IDrywallService
    {
        private readonly IDrywallRepository _repository;
        public DrywallService(IDrywallRepository repository)
        {
            _repository = repository;
        }

        public Drywall GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Drywall> GetAllData()
        {
            return _repository.GetAllData();
        }

        public void Create(Drywall drywall)
        {
            _repository.Create(drywall);
        }

        public void Delete(int id) 
        { 
            _repository.Delete(id); 
        }


    }
}

using DrywallModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallDB.Repository
{
    public interface IWallTypeRepository
    {
        public List<WallType> GetAllData();
        public WallType GetById(int id);
        public void Create (WallType wallType);

        public void Update (WallType wallType);

        public void Delete (int id);
    }
}

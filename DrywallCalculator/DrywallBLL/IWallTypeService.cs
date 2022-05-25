using DrywallModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallBLL
{
    public interface IWallTypeService
    {
        public WallType GetById(int id);

        public List<WallType> GetAll();

        public void Create(WallType wallType);

        public void Update(WallType wallType);

        public void Delete(int id);
    }
}

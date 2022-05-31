using DrywallDB.Data;
using DrywallModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallDB.Repository
{
    public class WallTypeRepository : IWallTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public WallTypeRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public WallType GetById(int id)
        {
            var wallType = _context.WallTypes.FirstOrDefault(w=>w.Id == id);

            return wallType;

        }


        public List<WallType> GetAllData()
        {
            var walls =_context.WallTypes.ToList();

            return walls;
        }

        public void Create(WallType wallType)
        {
            _context.Add(wallType);
            _context.SaveChanges();
        }

        public void Update(WallType wallType)
        {
            var wall =GetById(wallType.Id);
            wall.Name = wallType.Name;
            wall.FirstLayer = wallType.FirstLayer;
            wall.SecondLayer = wallType.SecondLayer;
            wall.Height = wallType.Height;
            wall.Width = wallType.Width;

            _context.SaveChanges();


        }

        public void Delete (int id)
        {
            var wall = GetById(id);
            _context.WallTypes.Remove(wall);
            _context.SaveChanges();
        }
         public void DeleteAll()
        {
            var wallList = GetAllData();
            foreach(WallType wallType in wallList)
            {
                _context.WallTypes.Remove(wallType);
            }
            _context.SaveChanges();
        }
    }
}

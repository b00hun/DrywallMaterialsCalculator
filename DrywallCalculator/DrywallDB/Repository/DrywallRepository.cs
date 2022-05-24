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
    public class DrywallRepository
    {
        
            private ApplicationDbContext _context;

            public DrywallRepository(ApplicationDbContext context)
            {
                _context = context;

            }

            public Drywall GetById(int id)
            {
                var wall = _context.Drywalls.Include(d=>d.WallType).FirstOrDefault(w => w.Id == id);

                return wall;

            }


            public List<Drywall> GetAllData()
            {
                var walls = _context.Drywalls.Include(w=>w.WallType).OrderByDescending(w => w.Id).ToList();

                return walls;
            }

            public void Create(WallType wallType)
            {
                _context.Add(wallType);
                _context.SaveChanges();
            }

            

            public void Delete(int id)
            {
                var wall = GetById(id);
                _context.Drywalls.Remove(wall);
                _context.SaveChanges();
            }

       
    }
}

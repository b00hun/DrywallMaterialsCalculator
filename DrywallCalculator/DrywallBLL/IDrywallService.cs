﻿using DrywallModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallBLL
{
    public interface IDrywallService
    {
        public Drywall GetById(int id);

        public List<Drywall> GetAllData();

        public void Create(WallType wallType);

        public void Delete(int id);

    }
}
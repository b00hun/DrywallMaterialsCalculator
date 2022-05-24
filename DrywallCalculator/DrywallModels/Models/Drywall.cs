using DrywallModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallModels.Enums
{
    public class Drywall
    {
        public int Id { get; set; }

        public float Length { get; set; }

        public WallType WallType { get; set; }
    }
}

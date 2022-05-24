using DrywallModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallModels.Models
{
    public class WallType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Height { get; set; }

        public float Width { get; set; }

        public MaterialType FirstLayer { get; set; }
        public MaterialType? SecondLayer { get; set; }

        public List<Drywall> Drywalls { get; set; }
    }
}

using DrywallModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallModels.Models
{
    public class Drywall
    {
        public int Id { get; set; }
        
        public float Length { get; set; }

        public int WallTypeId { get; set; }

        [Required(ErrorMessage= "Podaj typ ściany")]
        public WallType? WallType { get; set; }
    }
}

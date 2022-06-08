using DrywallModels.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DrywallCalculator.ViewModels
{
    public class DrywallCreateViewModel
    {
        public IEnumerable<Drywall>? Drywalls{ get; set; }

        [Required]
        public Drywall? Drywall{ get; set; }
        
        
        [ValidateNever]
        public IEnumerable<SelectListItem> WallTypeList { get; set; }
    }
}

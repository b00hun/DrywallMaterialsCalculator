using DrywallModels.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrywallCalculator.ViewModels
{
    public class DrywallCreateViewModel
    {
        public Drywall Drywall{ get; set; }
        
        
        [ValidateNever]
        public IEnumerable<SelectListItem> WallTypeList { get; set; }
    }
}

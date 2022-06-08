using DrywallBLL;
using DrywallCalculator.ViewModels;
using DrywallModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrywallCalculator.Controllers
{
    public class DrywallController : Controller
    {

        private readonly IDrywallService _drywallService;
        private readonly IWallTypeService _wallTypeService;

        public DrywallController(IDrywallService drywallService, IWallTypeService wallTypeService)
        {
            _wallTypeService = wallTypeService;
            _drywallService = drywallService;
        }

        // GET: DrywallController
        public ActionResult Index()
        {
            DrywallCreateViewModel DrywallViewModel = new()
            {
                Drywalls = _drywallService.GetAllData(),
                Drywall = new(),
                WallTypeList = _wallTypeService.GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                })

            };
            return View(DrywallViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(DrywallCreateViewModel drywallModel)
        {
            if (drywallModel.Drywall.Length == 0 || drywallModel.Drywall.WallType == null )
            {

                return RedirectToAction(nameof(Index));

            }

            _drywallService.Create(drywallModel.Drywall);
            return RedirectToAction(nameof(Index));
      
            
        }

       

        // GET: DrywallController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DrywallController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

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
            List<Drywall> model = _drywallService.GetAllData();
            return View(model);
        }

        

        // GET: DrywallController/Create
        public ActionResult Create()
        {
            DrywallCreateViewModel DrywallViewModel = new()
            {
                Drywall = new(),
                WallTypeList = _wallTypeService.GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                })
               
            };
            return View(DrywallViewModel);
        }

        // POST: DrywallController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DrywallCreateViewModel drywallModel)
        {
            if (!ModelState.IsValid)
            {

                return View(drywallModel);
                
            }

                _drywallService.Create(drywallModel.Drywall);
                return RedirectToAction(nameof(Index));
            
            
              return View();
            
        }

        // GET: DrywallController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DrywallController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

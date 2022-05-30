using DrywallBLL;
using DrywallModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrywallCalculator.Controllers
{
    public class WallTypeController : Controller
    {
        private readonly IWallTypeService _WallTypeService;

        public WallTypeController(IWallTypeService WallTypeService)
        {
            _WallTypeService = WallTypeService;

        }

        // GET: WallTypeController
        public ActionResult Index()
        {
            List<WallType> model = _WallTypeService.GetAll();

            return View(model);
        }

       
        // GET: WallTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WallTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WallType model)
        {
            try
            {
                if (!ModelState.IsValid) 
                { 
                    return View(model); 
                }
                _WallTypeService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: WallTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            
            var model = _WallTypeService.GetById(id);


            return View(model);
        }

        // POST: WallTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WallType model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                _WallTypeService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: WallTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _WallTypeService.GetById(id);
            return View(model);
        }

        // POST: WallTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, WallType model)
        {
            try
            {
                _WallTypeService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrywallCalculator.Controllers
{
    public class WallTypeController : Controller
    {
        // GET: WallTypeController
        public ActionResult Index()
        {
            return View();
        }

       
        // GET: WallTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WallTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

 

        // GET: WallTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WallTypeController/Delete/5
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

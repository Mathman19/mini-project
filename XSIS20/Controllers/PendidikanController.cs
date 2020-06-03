using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XSIS20.DataAccess;
using XSIS20.ViewModel;

namespace XSIS20.Controllers
{
    public class PendidikanController : Controller
    {
        // GET: Pendidikan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            List<PendidikanViewModel> listPendidikan = PendidikanRepo.All();
            return PartialView("_List", listPendidikan);
        }

        public ActionResult ListByEducation(int id = 0)
        {
            // id = education_level_id
            return PartialView("_ListByEducation", PendidikanRepo.ByEducation(id));
        }

        public ActionResult Create()
        {
            ViewBag.Years = new SelectList(Enumerable.Range(1995, (DateTime.Today.Year - 1995) + 1).Select(x =>

           new SelectListItem()
           {
               Text = x.ToString(),
               Value = x.ToString()
           }), "Value", "Text");

            ViewBag.EducationList = new SelectList(EducationLevelRepo.All(), "id", "name");
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(PendidikanViewModel model)
        {
            ResponseResult result = PendidikanRepo.Update(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(long id)
        {
            ViewBag.Years = new SelectList(Enumerable.Range(1995, (DateTime.Today.Year - 1995) + 1).Select(x =>

           new SelectListItem()
           {
               Text = x.ToString(),
               Value = x.ToString()
           }), "Value", "Text");

            ViewBag.EducationList = new SelectList(EducationLevelRepo.All(), "id", "name");
            PendidikanViewModel model = PendidikanRepo.ById(id);
            return PartialView("_Edit", model);
        }

        [HttpPost]
        public ActionResult Edit(PendidikanViewModel model)
        {
            ResponseResult result = PendidikanRepo.Update(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(long id)
        {
            ViewBag.EducationList = new SelectList(EducationLevelRepo.All(), "id", "name");

            PendidikanViewModel model = PendidikanRepo.ById(id);
            return PartialView("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(PendidikanViewModel model)
        {
            ResponseResult result = PendidikanRepo.Delete(model.id);
            return Json(
                new
                {
                    success = result.Success,
                    message = result.Message,
                    entity = result.Entity
                },
                JsonRequestBehavior.AllowGet);
        }
    }
}
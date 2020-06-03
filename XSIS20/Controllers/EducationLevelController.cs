using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XSIS20.DataAccess;
using XSIS20.ViewModel;

namespace XSIS20.Controllers
{
    public class EducationLevelController : Controller
    {
        // GET: EducationLevel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            List<EducationLevelViewModel> listEducationLevel = EducationLevelRepo.All();
            return PartialView("_List", listEducationLevel); 
        }
    }
}
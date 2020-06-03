using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XSIS20.DataAccess;
using XSIS20.ViewModel;

namespace XSIS20.Controllers
{
    public class OrganisasiController : Controller
    {
        // GET: Organisasi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            List<OrganisasiViewModel> listOrganisasi = OrganisasiRepo.All();
            return PartialView("_List", listOrganisasi);
        }

        public ActionResult Create()
        {
            ViewBag.Years = new SelectList(Enumerable.Range(1995, (DateTime.Today.Year - 1995) + 1).Select(x =>

           new SelectListItem()
           {
               Text = x.ToString(),
               Value = x.ToString()
           }), "Value", "Text");
            return PartialView("_Create");
        }
    }
}
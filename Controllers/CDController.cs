using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Controllers;

namespace CDController
    public class CDController : Controller
    {

        [HttpGet("/CDs-list")]
        public ActionResult Index()
        {
          List<CDs> allCDs = CDs.GetAll();
          return View(allCDs);
        }

        [HttpGet("/CDs-list/new")]
        public ActionResult CreateForm()
        {
          return View();
        }

        [HttpPost("/CDs-list")]
        public ActionResult Create()
        {
          CDs newCDs = new CDs (Request.Form["new-CDs"]);
          newCDs.Save();
          List<CDs> allCDs = CDs.GetAll();
          return View("Index", allCDs);
        }

        [HttpPost("/CDs/delete")]
        public ActionResult DeleteAll()
        {
            Place.ClearAll();
            return View();
        }
    }
}

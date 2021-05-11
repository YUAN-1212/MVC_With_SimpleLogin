using Base.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0510.Controllers
{
    public class HomeController : Controller
    {
        private IPen _myPenService;
        private IAccount _myAccService;

        public HomeController(IPen myPenService, IAccount myAccService)
        {
            _myPenService = myPenService;
            _myAccService = myAccService;
        }
        public ActionResult Index()
        {
            var user = _myAccService.Accounts.ToList();

            string DrawResult = _myPenService.doDraw("Hello");
            string WriteResult = _myPenService.doWrite("Hello");
            ViewBag.DrawResult = DrawResult;
            ViewBag.WriteResult = WriteResult;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "您已經登入";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
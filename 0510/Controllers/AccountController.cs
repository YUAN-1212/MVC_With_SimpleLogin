using Base.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0510.Controllers
{
    public class AccountController : Controller
    {
        private IAccount _myAccService;

        public AccountController(IAccount myAccService)
        {
            _myAccService = myAccService;
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 登入頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 登入頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult GetLogin()
        {
            string f_strAccount = Request.Form["f_strAccount"].ToString();
            string f_strPassWord = Request.Form["f_strPassWord"].ToString();
            var user = _myAccService.Accounts.Where(x => x.Name == f_strAccount && x.Password == f_strPassWord).FirstOrDefault();
           
            if (user != null)
            {
                var jsonResult = new
                {
                    result = 0,
                    url = "/Home/About"
                };
                return Json(new { jsonResult });
            }
            else
            {
                var jsonResult = new
                {
                    result = -1,

                };
                return Json(new { jsonResult });
            }


        }
    }
}
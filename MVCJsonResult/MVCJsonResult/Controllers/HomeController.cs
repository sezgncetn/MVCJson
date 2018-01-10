using MVCJsonResult.Models;
using MVCJsonResult.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJsonResult.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = comments.OrderByDescending(x => x.ID).ToList();
            ViewBag.LastId = model.Count > 0 ? comments.FirstOrDefault().ID : 0;
            return View(model);
        }
        private static List<CommentModel> comments = new List<CommentModel>();

        [HttpPost]
        public JsonResult PostComment(CommentModel model)
        {
            comments.Add(model);
            return Json(model);
        }

        public ActionResult GetUsers()
        {
            var model = UserService.GetUsers();
            return View(model);
        }

        public JsonResult SearchFor(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                var model1 = UserService.GetUsers();
                return Json(model1,JsonRequestBehavior.AllowGet);
            }
            var model = UserService.GetUsers().Where(x => x.UserName.Contains(searchText)).ToList();
            return Json(model,JsonRequestBehavior.AllowGet);
        }

        
    }
}
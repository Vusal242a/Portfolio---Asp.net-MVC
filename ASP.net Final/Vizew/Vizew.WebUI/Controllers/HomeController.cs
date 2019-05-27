using System.Linq;
using System.Web.Mvc;
using Vizew.WebUI.Models;

namespace Vizew.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new VizewDbContext())
            {
                var news = db.News.ToList();
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //string id = Request.QueryString["id"];
            //if (string.IsNullOrWhiteSpace(id))
            //{
            //    id = Request.Form["id"];
            //}

            //string name = Request.Form["name"];
            //string email = Request.Form["email"];
            //string message = Request.Form["message"];



            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult AcrchiveGrid()
        {
            return View();
        }

        public ActionResult AcrchiveList()
        {
            return View();
        }

        public ActionResult SinglePost()
        {
            return View();
        }
               
        public ActionResult VideoPost()
        {
            return View();
        }


        public ActionResult Typography()
        {
            return View();
        }
    }
}
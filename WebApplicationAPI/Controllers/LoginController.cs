using System.Web.Mvc;

namespace WebApplicationAPI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string Usuario, string Contraseña)
        {
            if (Usuario == "Osiel" && Contraseña == "1524")
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
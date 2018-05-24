using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace mysite.Controllers
{
    public class HomeController : Controller
    {
        IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SiteDB"].ConnectionString);
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
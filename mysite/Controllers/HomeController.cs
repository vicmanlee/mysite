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
        /// <summary>
        /// 博文
        /// </summary>
        /// <returns></returns>
        public ActionResult Article()
        {
            return View();
        }
        /// <summary>
        /// 图集
        /// </summary>
        /// <returns></returns>
        public ActionResult Gallery()
        {
            return View();
        }
        /// <summary>
        /// 关于我
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            return View();
        }
    }
}
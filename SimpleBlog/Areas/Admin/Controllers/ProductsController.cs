using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return Content("Products Controller Index Action");
        }

        public ActionResult Update()
        {
            return Content("Products Controller Update Action");
        }
    }
}
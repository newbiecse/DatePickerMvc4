using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatePickerMvc4.Models;

namespace DatePickerMvc4.Controllers
{
    public class MyClassController : Controller
    {
        //
        // GET: /MyClass/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            MyClass m = new MyClass
            {
                MyDate = new DateTime(2013, 8, 19)
            };
            return View(m);
        }

    }
}

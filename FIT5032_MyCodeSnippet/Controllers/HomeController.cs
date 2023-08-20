using FIT5032_MyCodeSnippet.HelloWorld;
using FIT5032_MyCodeSnippet.Models.Exercise;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_MyCodeSnippet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            Hello hello = new Hello();
            // I assigned the ViewBag.Message to the result
            ViewBag.Message = hello.GetHello();



            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
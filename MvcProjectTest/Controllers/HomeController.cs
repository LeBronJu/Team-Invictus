using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProjectTest.Models;

namespace MvcProjectTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NewStoryModel newsStory = new NewStoryModel()
            {
                Headline = "Phew what a scorcher",
                ByLine = "Ron Journo",
                Content = "People are obsessed with the weather"
            };

            return View(newsStory);
        }
    }
}
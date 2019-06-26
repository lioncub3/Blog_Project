using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBlogs.Data;
using ProjectBlogs.Models;

namespace ProjectBlogs.Controllers
{
    public class HomeController : Controller
    {
        private BlogsContext db;

        public HomeController(BlogsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        public IActionResult Blog(int Id)
        {
            ViewBag.Comments = db.Comments.Where(c => c.Id_blog == Id);
            return View(db.Blogs.First(b => b.Id == Id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectBlogs.Data;
using ProjectBlogs.Models;

namespace ProjectBlogs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private BlogsContext db;

        public BlogController(BlogsContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (blog.Photo != null)
            {
                // путь к папке Files
                string path = "/images/" + blog.Photo.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream("~" + path, FileMode.Create))
                {
                    await blog.Photo.CopyToAsync(fileStream);
                }

                blog.PhotoUrl = path;
            }

            db.Blogs.Add(blog);
            db.SaveChanges();
            return View();
        }
    }
}
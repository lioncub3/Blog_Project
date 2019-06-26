using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IHostingEnvironment _hostingEnvironment;

        public BlogController(BlogsContext db, IHostingEnvironment hostingEnvironment)
        {
            this.db = db;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View(db.Blogs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid)
                return View(blog);
            if (blog.Photo != null)
            {
                string type = Path.GetExtension(blog.Photo.FileName);
                string name = $"{DateTime.Now.ToString("ssmmhhddMMyyyy")}{type}";
                // путь к папке Files
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photos", name);

                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await blog.Photo.CopyToAsync(fileStream);
                }

                blog.PhotoUrl = "/photos/" + name;
            }

            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            Blog blog = db.Blogs.First(i => i.Id == Id);

            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Blog model)
        {
            if (!ModelState.IsValid)
                return View(model);

            string fullPath = $"{_hostingEnvironment.WebRootPath}{model.PhotoUrl}";
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }

            if (model.Photo != null)
            {
                string type = Path.GetExtension(model.Photo.FileName);
                string name = $"{DateTime.Now.ToString("ssmmhhddMMyyyy")}{type}";
                // путь к папке Files
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photos", name);

                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await model.Photo.CopyToAsync(fileStream);
                }

                model.PhotoUrl = "/photos/" + name;
            }

            db.Blogs.Update(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Blog blog = db.Blogs.First(i => i.Id == Id);

            string fullPath = $"{_hostingEnvironment.WebRootPath}{blog.PhotoUrl}";
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }

            db.Blogs.Remove(blog);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ViewComments(int Id)
        {
            return View(db.Comments.Where(c => c.Id_blog == Id));
        }

        public IActionResult DeleteComment(int Id)
        {
            Comment comment = db.Comments.First(i => i.Id == Id);

            db.Comments.Remove(comment);
            db.SaveChanges();

            return RedirectToAction("ViewComments");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using ProjectBlogs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBlogs.Data
{
    public class BlogsContext: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public BlogsContext(DbContextOptions options) : base(options)
        {

        }
    }
}

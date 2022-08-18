using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tweeter.Web.Models;

namespace Tweeter.Web.Data
{
    //public class ApplicationDbContext
    //{
    //    public ApplicationDbContext()
    //    {
    //    }
    //}

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<PostModel> Posts { get; set; }
    }
}


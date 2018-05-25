using SimpleFormsAuth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleFormsAuth
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
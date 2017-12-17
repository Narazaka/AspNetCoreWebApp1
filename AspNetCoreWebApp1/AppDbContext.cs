using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreWebApp1.Models;

namespace AspNetCoreWebApp1
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) {
            dbContextOptionsBuilder.UseSqlite("FileName=./app.db");
        }

        public static ApplicationDbContext Current {
            get {
                if (_Current == null) _Current = new ApplicationDbContext();
                return _Current;
            }
        }

        private static ApplicationDbContext _Current;
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ObioraPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObioraPortfolio.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        private readonly DbContextOptions _options;

        public AppDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Profile> ProfileTbl { get; set; }
        public DbSet<Address> AddressTbl { get; set; }
        public DbSet<WorkExperience> WorkExperienceTbl { get; set; }
        public DbSet<ContactPage> ContactPageTbl { get; set; }

    }
}

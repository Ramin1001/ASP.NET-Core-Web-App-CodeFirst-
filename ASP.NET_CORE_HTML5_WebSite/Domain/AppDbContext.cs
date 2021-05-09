using ASP.NET_CORE_HTML5_WebSite.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
      
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {

                Id = "e93bdc39-c506-48e7-9eef-0bbc9c787f01",
                Name="admin",
                NormalizedName="ADMIN"

            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "cd3a17d6-e8d1-40b0-8ce4-b8acc14060f0",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email= "raminagayev78@gmail.com",
                NormalizedEmail="RAMINAGAYEV78@GMAIL.COM",
                EmailConfirmed=true,
                PasswordHash=new PasswordHasher<IdentityUser>().HashPassword(null, "superpasword"),
                SecurityStamp=string.Empty

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId= "e93bdc39-c506-48e7-9eef-0bbc9c787f01",
                UserId= "cd3a17d6-e8d1-40b0-8ce4-b8acc14060f0",

            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
               Id = new Guid("ad0e5ecf-18c0-4752-af7d-739d7e19a1fc"),
               CodeWord = "PageIndex",
               Title= "Page index"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("ffb11ae5-c98c-46e9-ae9d-eb2746ddb1a3"),
                CodeWord = "PageServices",
                Title = "Our services"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("a7faf7bd-24bf-4456-9cd1-a956dca1e55d"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });

        }

    }
}

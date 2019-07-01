using Chimper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Chimper.DAL
{
    public class ChimperContext : DbContext
    {
        public ChimperContext() : base("ChimperContext")
        {
        }

        public DbSet<AboutSayings> AboutSayings { get; set; }
        public DbSet<CompanyFeatures> CompanyFeatures { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<HomeBlog> HomeBlogs { get; set; }
        public DbSet<HomeCharach> HomeCharaches { get; set; }
        public DbSet<HomeProjects> HomeProjects { get; set; }
        public DbSet<MoreInfo> MoreInfos { get; set; }
        public DbSet<PopularPosts> PopularPosts { get; set; }
        public DbSet<RealBog> RealBogs { get; set; }
        public DbSet<ServicesResp> ServicesResps { get; set; }
        public DbSet<ServicesUpper> ServicesUppers { get; set; }
        public DbSet<Specialities> Specialities { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
    }
}
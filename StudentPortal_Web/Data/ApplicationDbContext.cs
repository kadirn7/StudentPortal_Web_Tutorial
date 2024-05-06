using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;
using System.Reflection;

namespace StudentPortal.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }

        public DbSet<Student>Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // builder.Entity<Article>().Property(x=>x.Title).HasMaxLength(150);
            // bu üstte yaptığımız da aynı mapping sınıfındaki gibi configure etmemizi sağlıyor
            // ama clean kod yapmak istedğimiz için pekte verimli değil.
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Mappingdeki bütün tanımlamaları tek bir seferde yapmak için kullanılıyor.
        }
    }
}

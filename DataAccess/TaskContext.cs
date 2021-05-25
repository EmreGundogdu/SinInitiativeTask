using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TaskContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;initial catalog=01.Task;integrated security=true");
        }
        public DbSet<Abouts> Abouts { get; set; }
        public DbSet<Banners> Banners { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoriesNewsRelations> CategoriesNewsRelations { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<TagNewRelations> TagNewRelations { get; set; }
        public DbSet<Tags> Tags { get; set; }
    }
}

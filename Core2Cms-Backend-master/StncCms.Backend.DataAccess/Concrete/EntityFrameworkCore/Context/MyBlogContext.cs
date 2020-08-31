using Microsoft.EntityFrameworkCore;
using StncCms.Backend.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using StncCms.Backend.Entities.Concrete;

namespace StncCms.Backend.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class MyBlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=UdemyBlog; user id=sa; password=1;");
            optionsBuilder.UseSqlServer("server=.; database=ServiceCMS; integrated security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryBlogMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
        }


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

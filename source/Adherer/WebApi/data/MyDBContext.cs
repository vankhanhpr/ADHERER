using Microsoft.EntityFrameworkCore;
using WebApi.model;
using WebApi.serrvice.admin.model;

namespace WebApi.data
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<DangBo> Dangbo { get; set; }
        public DbSet<ChiBo> Chibo { get; set; }
        public DbSet<Nation> Nation { get; set; }
    }
}

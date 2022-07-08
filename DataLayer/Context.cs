using DataLayer.Entites.Account;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }

        public DbSet<User> Registers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var cascade = builder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(x => x.DeleteBehavior == DeleteBehavior.Cascade);

            foreach(var fk in cascade)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Identity;
using Project.Domain.Entities.Sample;

namespace Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<User,
        Role, string, UserClaim,
        UserRole,
        UserLogin,
        RoleClaim,
        UserToken>
    {
        public DbSet<UserJwt> UserJwts { get; set; }
        public DbSet<Sample> Samples { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users", SchemaNames.IdentitySchemaName);
            modelBuilder.Entity<Role>().ToTable("Roles", SchemaNames.IdentitySchemaName);
            modelBuilder.Entity<UserClaim>().ToTable("UserClaims", SchemaNames.IdentitySchemaName);
            modelBuilder.Entity<UserLogin>().ToTable("UserLogins", SchemaNames.IdentitySchemaName);
            modelBuilder.Entity<UserRole>().ToTable("UserRoles", SchemaNames.IdentitySchemaName);
            modelBuilder.Entity<RoleClaim>().ToTable("RoleClaims", SchemaNames.IdentitySchemaName);
            modelBuilder.Entity<UserToken>().ToTable("UserTokens", SchemaNames.IdentitySchemaName);
            modelBuilder.Entity<UserJwt>().ToTable("UserJwts", SchemaNames.IdentitySchemaName);
        }
    }
}


using CleanArchitecture.Auditing;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Entity;
using CleanArchitecture.Domain.Entity.Lookup;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence
{
    public class ApplicationDbContext : AuditableDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.EnableAuditHistory();
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        #region Lookups
        public DbSet<LookupMasterEntity> LookupMasters { get; set; }
        public DbSet<LookupDetailEntity> LookupDetails { get; set; }
       
        #endregion
    }
}

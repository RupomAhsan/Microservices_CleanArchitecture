using CleanArchitecture.Auditing;
using CleanArchitecture.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence
{
    public abstract class AuditableDbContext : DbContext
    {
        public AuditableDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual async Task<int> SaveChangesAsync(string username = "SYSTEM")
        {
            if (string.IsNullOrEmpty(username))
                username = "SYSTEM";
            foreach (var entry in base.ChangeTracker.Entries<BaseAuditEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.LastModifiedDate = DateTime.Now;
                entry.Entity.LastModifiedBy = username;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                    entry.Entity.CreatedBy = username;
                }
            }
          //  this.EnsureAuditHistory(username);
            var result = 0;
            try
            {
                 result = await base.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return result;
        }
    }
}

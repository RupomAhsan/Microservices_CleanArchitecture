using Ardalis.Specification.EntityFrameworkCore;
using CleanArchitecture.Domain.Entity.Lookup;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories
{
    public class LookupDetailRepository : RepositoryBase<LookupDetailEntity>
    {
        public LookupDetailRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}

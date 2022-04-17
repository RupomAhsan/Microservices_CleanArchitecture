using CleanArchitecture.Application.Contracts.Persistence.Lookups;
using CleanArchitecture.Domain.Entity.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Lookups
{
    public class LookupMasterRepository : GenericRepository<LookupMasterEntity>, ILookupMasterRepository
    {
        private readonly LetsRideDbContext _dbContext;

        public LookupMasterRepository(LetsRideDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

using CleanArchitecture.Application.Contracts.Persistence.Lookups;
using CleanArchitecture.Domain.Entity.Lookup;

namespace CleanArchitecture.Persistence.Repositories.Lookups;

public class LookupDetailRepository : GenericRepository<LookupDetailEntity>, ILookupDetailRepository
{
    private readonly LetsRideDbContext _dbContext;

    public LookupDetailRepository(LetsRideDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<LookupDetailEntity> AddAsync(LookupDetailEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<LookupDetailEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<LookupDetailEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(LookupDetailEntity entity)
    {
        throw new NotImplementedException();
    }
}

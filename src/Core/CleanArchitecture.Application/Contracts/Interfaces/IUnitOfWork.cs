
using CleanArchitecture.Domain.Entity;
using CleanArchitecture.Domain.Entity.Lookup;

namespace CleanArchitecture.Application.Contracts.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<LookupDetailEntity> LookupDetailEntityRepository { get; }
        IRepository<LookupMasterEntity> LookupMasterRepository { get; }
        Task<bool> SaveAsync();
    }
}


namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class
    {
    }
}

using Ardalis.Specification;

namespace CleanArchitecture.Application.Contracts.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class
{
}

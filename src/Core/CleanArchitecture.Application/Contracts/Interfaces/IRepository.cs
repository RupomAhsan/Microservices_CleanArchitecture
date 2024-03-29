﻿using Ardalis.Specification;

namespace CleanArchitecture.Application.Contracts.Interfaces;

// from Ardalis.Specification
public interface IRepository<T> : IRepositoryBase<T> where T : class
{
}

using CleanArchitecture.Application.Contracts.Interfaces;
using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Domain.Entity.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.Lookups
{
    public interface ILookupMasterRepository :IGenericRepository<LookupMasterEntity>
    {

    }
}

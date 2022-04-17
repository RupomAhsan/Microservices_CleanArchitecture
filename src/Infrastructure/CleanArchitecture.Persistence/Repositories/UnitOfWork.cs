using CleanArchitecture.Application.Constants;
using CleanArchitecture.Application.Contracts.Interfaces;
using CleanArchitecture.Domain.Entity;
using CleanArchitecture.Domain.Entity.Lookup;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public readonly IRepository<LookupDetailEntity> _LookupDetailEntityRepository;
        private readonly IRepository<LookupMasterEntity> _LookupMasterRepository;

        public UnitOfWork(
            ApplicationDbContext context, 
            IHttpContextAccessor httpContextAccessor,
            IRepository<LookupDetailEntity> lookupDetailEntityRepository,
            IRepository<LookupMasterEntity> lookupMasterRepository
            )
        {
            _context = context;
            this._httpContextAccessor = httpContextAccessor;
            _LookupDetailEntityRepository = lookupDetailEntityRepository;
            _LookupMasterRepository = lookupMasterRepository;
        }

        public IRepository<LookupDetailEntity> LookupDetailEntityRepository => _LookupDetailEntityRepository;// ??= new LeaveAllocationRepository(_context);
        public IRepository<LookupMasterEntity> LookupMasterRepository => _LookupMasterRepository;

        //public ILookupDetailRepository LookupDetailRepository =>
        //    _lookupDetailRepository ??= new LookupDetailRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        
        public async Task<bool> SaveAsync() 
        {
            bool returnValue = true;
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var username = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid)?.Value;
                    await _context.SaveChangesAsync();
                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //Log Exception Handling message                      
                    returnValue = false;
                    dbContextTransaction.Rollback();
                }
            }
            return returnValue;
            //  var username = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid)?.Value;

            //  await _context.SaveChangesAsync(username);
        }
    }
}

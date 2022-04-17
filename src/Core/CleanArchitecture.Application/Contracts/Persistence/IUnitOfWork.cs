

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        //ILeaveAllocationRepository LeaveAllocationRepository { get; }
        //ILeaveRequestRepository LeaveRequestRepository { get; }
        //ILeaveTypeRepository LeaveTypeRepository { get; }
        //ILookupMasterRepository LookupMasterRepository { get; }
        //ILookupDetailRepository LookupDetailRepository { get; }
        Task Save();
    }
}

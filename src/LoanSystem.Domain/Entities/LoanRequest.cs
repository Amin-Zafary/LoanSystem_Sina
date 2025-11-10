using System;

namespace LoanSystem.Domain.Entities
{
    public enum RequestStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class LoanRequest
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid CustomerId { get; private set; }
        public Guid FacilityId { get; private set; }
        public RequestStatus Status { get; private set; } = RequestStatus.Pending;
        public DateTime StatusChangedAt { get; private set; } = DateTime.UtcNow;

        public LoanRequest(Guid customerId, Guid facilityId)
        {
            CustomerId = customerId;
            FacilityId = facilityId;
        }

        public void SetStatus(RequestStatus status)
        {
            Status = status;
            StatusChangedAt = DateTime.UtcNow;
        }
    }
}

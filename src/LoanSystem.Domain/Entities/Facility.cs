using System;

namespace LoanSystem.Domain.Entities
{
    public class Facility
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Code { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
        public Guid FacilityGroupId { get; private set; }
        public int PaymentStages { get; private set; }

        public Facility(string code, string name, Guid facilityGroupId, int paymentStages)
        {
            Code = code;
            Name = name;
            FacilityGroupId = facilityGroupId;
            PaymentStages = paymentStages;
        }
    }
}

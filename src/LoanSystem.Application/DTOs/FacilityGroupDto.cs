using System;

namespace LoanSystem.Application.DTOs
{
    public class FacilityGroupDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public decimal InterestRate { get; set; }
        public int RepaymentPeriodMonths { get; set; }
        public decimal LateFeeRate { get; set; }
    }
}

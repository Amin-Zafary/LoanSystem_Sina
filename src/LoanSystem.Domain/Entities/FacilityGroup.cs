using System;

namespace LoanSystem.Domain.Entities
{
    public class FacilityGroup
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; } = string.Empty;
        public string Code { get; private set; } = string.Empty;
        public decimal InterestRate { get; private set; }
        public int RepaymentPeriodMonths { get; private set; }
        public decimal LateFeeRate { get; private set; }

        public FacilityGroup(string name, string code, decimal interestRate, int repaymentPeriodMonths, decimal lateFeeRate)
        {
            Name = name;
            Code = code;
            InterestRate = interestRate;
            RepaymentPeriodMonths = repaymentPeriodMonths;
            LateFeeRate = lateFeeRate;
        }
    }
}

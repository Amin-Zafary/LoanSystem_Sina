using System;

namespace LoanSystem.Domain.Entities
{
    public class BankUser
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string PersonnelCode { get; private set; } = string.Empty;
        public string Unit { get; private set; } = string.Empty;

        public BankUser(string firstName, string lastName, string personnelCode, string unit)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonnelCode = personnelCode;
            Unit = unit;
        }
    }
}

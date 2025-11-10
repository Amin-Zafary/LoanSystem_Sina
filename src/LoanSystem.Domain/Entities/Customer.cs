using System;

namespace LoanSystem.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string NationalCode { get; private set; } = string.Empty;
        public string ContactInfo { get; private set; } = string.Empty;
        public string CustomerNumber { get; private set; } = string.Empty;

        public Customer(string firstName, string lastName, string nationalCode, string contactInfo, string customerNumber)
        {
            if (string.IsNullOrWhiteSpace(nationalCode)) throw new ArgumentException(nameof(nationalCode));
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            ContactInfo = contactInfo;
            CustomerNumber = customerNumber;
        }
    }
}

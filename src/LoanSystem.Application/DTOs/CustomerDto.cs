using System;

namespace LoanSystem.Application.DTOs
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string NationalCode { get; set; } = string.Empty;
        public string ContactInfo { get; set; } = string.Empty;
        public string CustomerNumber { get; set; } = string.Empty;
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace LoanSystem.Application.DTOs
{
    public class LoanRequestDto
    {
        public Guid Id { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        public Guid FacilityId { get; set; }

        public string Status { get; set; } = string.Empty;
        public DateTime StatusChangedAt { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace LoanSystem.Application.DTOs
{
    public class FacilityDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "FacilityGroupId is required")]
        public Guid FacilityGroupId { get; set; }
        
        [Range(1, 100, ErrorMessage = "PaymentStages must be between 1 and 100")]
        public int PaymentStages { get; set; }
        
    }
}

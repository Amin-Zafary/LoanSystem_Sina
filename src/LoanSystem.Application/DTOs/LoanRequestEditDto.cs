using LoanSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Application.DTOs
{
    public class LoanRequestEditDto
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = "";
        public string FacilityName { get; set; } = "";
        public RequestStatus Status { get; set; } = RequestStatus.Pending;

        public DateTime StatusChangedAt { get; set; } = DateTime.Now;
    }
}

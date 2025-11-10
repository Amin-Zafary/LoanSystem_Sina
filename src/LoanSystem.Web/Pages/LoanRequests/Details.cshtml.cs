using AutoMapper;
using LoanSystem.Application.DTOs;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace LoanSystem.Web.Pages.LoanRequests
{
    public class DetailsModel : PageModel
    {
        private readonly IRepository<LoanRequest> _loanRepo;
        private readonly IRepository<Customer> _customerRepo;
        private readonly IRepository<Facility> _facilityRepo;
        private readonly IMapper _mapper;

        [BindProperty]
        //public LoanRequest LoanRequest { get; set; } = new();
        public LoanRequestEditDto LoanRequestEditDto { get; set; } = new LoanRequestEditDto();

        //public List<SelectListItem> StatusOptions { get; set; } = new();

        public DetailsModel(
            IRepository<LoanRequest> loanRepo,
            IRepository<Customer> customerRepo,
            IRepository<Facility> facilityRepo,
            IMapper mapper)
        {
            _loanRepo = loanRepo;
            _customerRepo = customerRepo;
            _facilityRepo = facilityRepo;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var entity = await _loanRepo.GetByIdAsync(id);

            if (entity == null)
            {
                return NotFound();
            }
            else
            {
                if (entity.CustomerId != null && entity.FacilityId != null)
                {
                    var customer = await _customerRepo.GetByIdAsync(entity.CustomerId);
                    var facility = await _facilityRepo.GetByIdAsync(entity.FacilityId);
                    LoanRequestEditDto.Id = entity.Id;
                    LoanRequestEditDto.CustomerName = customer?.FirstName + " " + customer?.LastName;
                    LoanRequestEditDto.FacilityName = facility.Name;
                    LoanRequestEditDto.Status = entity.Status;
                    LoanRequestEditDto.StatusChangedAt = entity.StatusChangedAt;
                }
            }
            return Page();
        }
    }
}
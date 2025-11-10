using AutoMapper;
using LoanSystem.Application.DTOs;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace LoanSystem.Web.Pages.LoanRequests
{
    public class CreateModel : PageModel
    {
        private readonly IRepository<LoanRequest> _loanRepo;
        private readonly IRepository<Customer> _customerRepo;
        private readonly IRepository<Facility> _facilityRepo;
        private readonly IMapper _mapper;

        [BindProperty]
        public LoanRequestDto Input { get; set; } = new();

        public List<SelectListItem> Customers { get; set; } = new();
        public List<SelectListItem> Facilities { get; set; } = new();

        public CreateModel(IRepository<LoanRequest> loanRepo, IRepository<Customer> customerRepo, IRepository<Facility> facilityRepo, IMapper mapper)
        {
            _loanRepo = loanRepo;
            _customerRepo = customerRepo;
            _facilityRepo = facilityRepo;
            _mapper = mapper;
        }

        public async Task OnGetAsync()
        {
            var customers = await _customerRepo.GetAllAsync();
            var facilities = await _facilityRepo.GetAllAsync();

            Customers = customers.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = $"{c.FirstName} {c.LastName}"}).ToList();
            Facilities = facilities.Select(f => new SelectListItem { Value = f.Id.ToString(), Text = $"{f.Name} ({f.Code})" }).ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                await OnGetAsync();
                return Page();
            }

            var entity = _mapper.Map<LoanRequest>(Input);
            await _loanRepo.AddAsync(entity);
            return RedirectToPage("Index");
        }
    }
}

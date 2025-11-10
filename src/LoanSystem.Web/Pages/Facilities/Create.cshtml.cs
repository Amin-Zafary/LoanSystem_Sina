using AutoMapper;
using LoanSystem.Application.DTOs;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoanSystem.Web.Pages.Facilities
{
    public class CreateModel : PageModel
    {
        //private readonly IRepository<Facility> _repo;
        private readonly IRepository<Facility> _facilityRepo;
        private readonly IRepository<FacilityGroup> _groupRepo;
        private readonly IMapper _mapper;

        [BindProperty]
        public FacilityDto Input { get; set; } = new FacilityDto();

        public List<SelectListItem> FacilityGroupOptions { get; set; } = new();

        public CreateModel(IRepository<Facility> facilityRepo, IRepository<FacilityGroup> groupRepo, IMapper mapper)
        {
            _facilityRepo = facilityRepo;
            _groupRepo = groupRepo;
            _mapper = mapper;
        }
        //public void OnGet() { }

        public async Task OnGetAsync()
        {
            var groups = await _groupRepo.GetAllAsync();
            FacilityGroupOptions = groups.Select(g => new SelectListItem
            {
                Value = g.Id.ToString(),
                Text = $"{g.Code} - {g.Name}"
            }).ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var entity = _mapper.Map<Facility>(Input);
            await _facilityRepo.AddAsync(entity);

            return RedirectToPage("Index");
        }
    }
}


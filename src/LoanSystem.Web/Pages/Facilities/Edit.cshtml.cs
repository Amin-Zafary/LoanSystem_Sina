using AutoMapper;
using LoanSystem.Application.DTOs;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoanSystem.Web.Pages.Facilities
{
    public class EditModel : PageModel
    {
        //private readonly IRepository<Facility> _repo;
        private readonly IRepository<Facility> _facilityRepo;
        private readonly IRepository<FacilityGroup> _groupRepo;
        private readonly IMapper _mapper;

        //[BindProperty]
        //public Facility Input { get; set; } = new Facility("", "", Guid.Empty, 0);
        [BindProperty]
        public FacilityDto Input { get; set; } = new FacilityDto();

        //public EditModel(IRepository<Facility> repo) => _repo = repo;
        public EditModel(IRepository<Facility> facilityRepo, IRepository<FacilityGroup> groupRepo, IMapper mapper)
        {
            _facilityRepo = facilityRepo;
            _groupRepo = groupRepo;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var f = await _facilityRepo.GetByIdAsync(id);
            var fd = _mapper.Map<FacilityDto>(f);
            if (f == null) return NotFound();
            Input = fd;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var entity = _mapper.Map<Facility>(Input);
                await _facilityRepo.UpdateAsync(entity);
                return RedirectToPage("Index");
            }
        }
    }
}

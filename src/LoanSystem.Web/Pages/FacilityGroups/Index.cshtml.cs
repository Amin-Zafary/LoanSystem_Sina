using Microsoft.AspNetCore.Mvc.RazorPages;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;

namespace LoanSystem.Web.Pages.FacilityGroups
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<FacilityGroup> _repo;
        public IndexModel(IRepository<FacilityGroup> repo) => _repo = repo;
        public IEnumerable<FacilityGroup> FacilityGroups { get; set; } = Enumerable.Empty<FacilityGroup>();

        public async Task OnGetAsync()
        {
            FacilityGroups = await _repo.GetAllAsync();
        }
    }
}

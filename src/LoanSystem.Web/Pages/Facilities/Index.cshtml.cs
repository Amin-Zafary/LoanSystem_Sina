using Microsoft.AspNetCore.Mvc.RazorPages;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;

namespace LoanSystem.Web.Pages.Facilities
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Facility> _repo;
        public IndexModel(IRepository<Facility> repo) => _repo = repo;
        public IEnumerable<Facility> Facilities { get; set; } = Enumerable.Empty<Facility>();

        public async Task OnGetAsync()
        {
            Facilities = await _repo.GetAllAsync();
        }
    }
}

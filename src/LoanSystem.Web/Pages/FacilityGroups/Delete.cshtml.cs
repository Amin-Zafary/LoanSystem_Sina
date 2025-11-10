using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LoanSystem.Application.Interfaces;

namespace LoanSystem.Web.Pages.FacilityGroups
{
    public class DeleteModel : PageModel
    {
        private readonly IRepository<LoanSystem.Domain.Entities.FacilityGroup> _repo;
        public DeleteModel(IRepository<LoanSystem.Domain.Entities.FacilityGroup> repo) => _repo = repo;

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            await _repo.DeleteAsync(id);
            return RedirectToPage("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;

namespace LoanSystem.Web.Pages.FacilityGroups
{
    public class EditModel : PageModel
    {
        private readonly IRepository<FacilityGroup> _repo;
        [BindProperty]
        public FacilityGroup Input { get; set; } = new FacilityGroup("", "", 0, 0, 0);

        public EditModel(IRepository<FacilityGroup> repo) => _repo = repo;

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var fg = await _repo.GetByIdAsync(id);
            if (fg == null) return NotFound();
            Input = fg;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            await _repo.UpdateAsync(Input);
            return RedirectToPage("Index");
        }
    }
}

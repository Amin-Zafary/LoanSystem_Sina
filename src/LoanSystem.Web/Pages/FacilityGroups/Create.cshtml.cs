using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;

namespace LoanSystem.Web.Pages.FacilityGroups
{
    public class CreateModel : PageModel
    {
        private readonly IRepository<FacilityGroup> _repo;
        [BindProperty]
        public FacilityGroup Input { get; set; } = new FacilityGroup("", "", 0, 0, 0);

        public CreateModel(IRepository<FacilityGroup> repo) => _repo = repo;
        public void OnGet() { }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            await _repo.AddAsync(new FacilityGroup(Input.Name, Input.Code, Input.InterestRate, Input.RepaymentPeriodMonths, Input.LateFeeRate));
            return RedirectToPage("Index");
        }
    }
}

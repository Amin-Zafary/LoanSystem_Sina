using AutoMapper;
using LoanSystem.Application.DTOs;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace LoanSystem.Web.Pages.LoanRequests
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<LoanRequest> _loanRepo;
        private readonly IRepository<Customer> _customerRepo;
        private readonly IRepository<Facility> _facilityRepo;
        //private readonly IMapper _mapper;

        //public LoanRequestEditDto LoanRequestEditDto { get; set; } = new LoanRequestEditDto();
        public LoanRequestEditDto LoanRequestEditDto;
        public List<LoanRequestEditDto> LoanRequestEditDtoList { get; set; } = new();

        public IndexModel(IRepository<LoanRequest> loanRepo , IRepository<Customer> customerRepo,
            IRepository<Facility> facilityRepo)
        {
            _loanRepo = loanRepo;
            _customerRepo = customerRepo;
            _facilityRepo = facilityRepo;
        }

        

        public async Task OnGetAsync()
        {
            var LoanRequests = (await _loanRepo.GetAllAsync()).ToList();
            foreach (var entity in LoanRequests)
            {
                LoanRequestEditDto = new LoanRequestEditDto();
                var customer = await _customerRepo.GetByIdAsync(entity.CustomerId);
                var facility = await _facilityRepo.GetByIdAsync(entity.FacilityId);

                LoanRequestEditDto.Id = entity.Id;
                LoanRequestEditDto.CustomerName = customer?.FirstName + " " + customer?.LastName;
                LoanRequestEditDto.FacilityName = facility.Name;
                LoanRequestEditDto.Status = entity.Status;

                LoanRequestEditDtoList.Add(LoanRequestEditDto);
            }
            

            //LoanRequests = (await _loanRepo.GetAllAsync()).ToList();
            
        }
    }
}

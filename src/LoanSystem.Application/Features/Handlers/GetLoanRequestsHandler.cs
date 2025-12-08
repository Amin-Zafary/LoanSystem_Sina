using LoanSystem.Application.DTOs;
using LoanSystem.Application.Features.Queries;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Application.Features.Handlers
{
    public class GetLoanRequestsHandler : IRequestHandler<GetLoanRequestsQuery, IEnumerable<LoanRequest>>
    {
        private readonly IRepository<LoanRequest> _Loanrepo;
        //private readonly IRepository<Customer> _customerRepo;
        //private readonly IRepository<Facility> _facilityRepo;

        //public LoanRequestEditDto LoanRequestEditDto;
        //public List<LoanRequestEditDto> LoanRequestEditDtoList { get; set; } = new();

        public GetLoanRequestsHandler(IRepository<LoanRequest> repo)
        {
            _Loanrepo = repo;

        }

        public async Task<IEnumerable<LoanRequest>> Handle(GetLoanRequestsQuery request, CancellationToken cancellationToken)
        {
            return await _Loanrepo.GetAllAsync(cancellationToken);
        }
    }
    /*public class GetLoanRequestsHandler
    {
    }*/
}

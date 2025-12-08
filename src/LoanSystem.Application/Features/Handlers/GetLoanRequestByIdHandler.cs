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
    public class GetLoanRequestByIdHandler : IRequestHandler<GetLoanRequestByIdQuery, LoanRequest?>
    {
        private readonly IRepository<LoanRequest> _repo;

        public GetLoanRequestByIdHandler(IRepository<LoanRequest> repo)
        {
            _repo = repo;
        }

        public async Task<LoanRequest?> Handle(GetLoanRequestByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByIdAsync(request.Id, cancellationToken);
        }
    }
    /*internal class GetLoanRequestByIdHandler
    {
    }*/
}

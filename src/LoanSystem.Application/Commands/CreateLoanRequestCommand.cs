using System;
using System.Threading;
using System.Threading.Tasks;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;

namespace LoanSystem.Application.Commands
{
    public class CreateLoanRequestCommand
    {
        private readonly IRepository<LoanRequest> _repo;
        public CreateLoanRequestCommand(IRepository<LoanRequest> repo) => _repo = repo;

        public async Task<LoanRequest> ExecuteAsync(Guid customerId, Guid facilityId, CancellationToken ct = default)
        {
            var req = new LoanRequest(customerId, facilityId);
            await _repo.AddAsync(req, ct);
            return req;
        }
    }
}

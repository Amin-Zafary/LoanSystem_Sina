/*using LoanSystem.Application.Features.Commands;
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
    public class UpdateLoanRequestStatusHandler : IRequestHandler<UpdateLoanRequestStatusCommand, bool>
    {
        private readonly IRepository<LoanRequest> _repo;

        public UpdateLoanRequestStatusHandler(IRepository<LoanRequest> repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(UpdateLoanRequestStatusCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByIdAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            entity.Status = request.Status;
            await _repo.UpdateAsync(entity, cancellationToken);
            return true;
        }
    }
    *//*internal class UpdateLoanRequestStatusHandler
    {
    }*//*
}
*/
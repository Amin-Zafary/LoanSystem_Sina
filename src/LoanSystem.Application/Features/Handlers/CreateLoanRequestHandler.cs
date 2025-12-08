using AutoMapper;
using LoanSystem.Application.Features.Queries;
using LoanSystem.Application.Features.Commands;
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
    /*public class CreateLoanRequestHandler : IRequestHandler<CreateLoanRequestCommand, Guid>
    {
        private readonly IRepository<LoanRequest> _repo;
        private readonly IMapper _mapper;

        public CreateLoanRequestHandler(IRepository<LoanRequest> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateLoanRequestCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<LoanRequest>(request.Dto);
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            await _repo.AddAsync(entity, cancellationToken);
            return entity.Id;
        }
    }*/
}
    internal class CreateLoanRequestHandler
    {
    }
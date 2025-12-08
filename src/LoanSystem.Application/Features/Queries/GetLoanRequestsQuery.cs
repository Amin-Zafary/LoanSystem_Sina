using LoanSystem.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Application.Features.Queries
{
    public record GetLoanRequestsQuery() : IRequest<IEnumerable<LoanRequest>>;
    /*internal class GetLoanRequestsQuery
    {
    }*/
}

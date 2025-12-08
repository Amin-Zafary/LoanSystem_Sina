using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Application.Features.Commands
{
    public record UpdateLoanRequestStatusCommand(Guid Id, string Status) : IRequest<bool>;
    /*internal class UpdateLoanRequestStatusCommand
    {
    }*/
}

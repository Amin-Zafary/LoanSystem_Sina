using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Application.Features.Commands
{
    public record DeleteLoanRequestCommand(Guid Id) : IRequest<bool>;
    /*internal class DeleteLoanRequestCommand
    {
    }*/
}

using LoanSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace LoanSystem.Application.Features.Commands
{
    public record CreateLoanRequestCommand(LoanRequestDto Dto) : IRequest<Guid>;
    /*internal class CreateLoanRequestCommand
    {
    }*/
}

using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using LoanSystem.Application.Commands;
//using LoanSystem.Application.Features.Commands;
using LoanSystem.Application.Interfaces;
using LoanSystem.Domain.Entities;

namespace LoanSystem.Tests.Unit
{
    public class CreateLoanRequestCommandTests
    {
        [Fact]
        public async Task ExecuteAsync_CreatesLoanRequest_And_CallsRepoAdd()
        {
            var mockRepo = new Mock<IRepository<LoanRequest>>();
            mockRepo.Setup(r => r.AddAsync(It.IsAny<LoanRequest>(), default)).Returns(Task.CompletedTask);
            var cmd = new CreateLoanRequestCommand(mockRepo.Object);
            var customerId = Guid.NewGuid();
            var facilityId = Guid.NewGuid();

            var result = await cmd.ExecuteAsync(customerId, facilityId);

            Assert.NotNull(result);
            Assert.Equal(customerId, result.CustomerId);
            Assert.Equal(facilityId, result.FacilityId);
            Assert.Equal(RequestStatus.Pending, result.Status);
            mockRepo.Verify(r => r.AddAsync(It.IsAny<LoanRequest>(), default), Times.Once);
        }
    }
}

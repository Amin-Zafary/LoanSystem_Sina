using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LoanSystem.Application.Interfaces
{
    public interface IRepository<T>
    {
        Task<T?> GetByIdAsync(Guid id, CancellationToken ct = default);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken ct = default);
        Task AddAsync(T entity, CancellationToken ct = default);
        Task UpdateAsync(T entity, CancellationToken ct = default);
        Task DeleteAsync(Guid id, CancellationToken ct = default);
    }
}

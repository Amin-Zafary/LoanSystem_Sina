using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LoanSystem.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using LoanSystem.Infrastructure.Persistence;

namespace LoanSystem.Infrastructure.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _db;
        private readonly DbSet<T> _set;

        public GenericRepository(AppDbContext db)
        {
            _db = db;
            _set = _db.Set<T>();
        }

        public async Task AddAsync(T entity, CancellationToken ct = default)
        {
            await _set.AddAsync(entity, ct);
            await _db.SaveChangesAsync(ct);
        }

        public async Task DeleteAsync(Guid id, CancellationToken ct = default)
        {
            var entity = await _set.FindAsync(new object[] { id }, ct);
            if (entity == null) return;
            _set.Remove(entity);
            await _db.SaveChangesAsync(ct);
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken ct = default)
        {
            return await _set.ToListAsync(ct);
        }

        public async Task<T?> GetByIdAsync(Guid id, CancellationToken ct = default)
        {
            return await _set.FindAsync(new object[] { id }, ct);
        }

        public async Task UpdateAsync(T entity, CancellationToken ct = default)
        {
            _set.Update(entity);
            await _db.SaveChangesAsync(ct);
        }
    }
}

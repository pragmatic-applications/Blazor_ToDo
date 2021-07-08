using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Database;

using Interfaces;

using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(ApplicationDbContext applicationDbContext) => this.ApplicationDbContext = applicationDbContext;

        protected ApplicationDbContext ApplicationDbContext { get; set; }

        public IQueryable<T> Get() => this.ApplicationDbContext.Set<T>().AsNoTracking();

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate) => this.ApplicationDbContext.Set<T>().Where(predicate).AsNoTracking();

        public async Task<ICollection<T>> GetOrderByAsync() => await this.Get().OrderBy(t => t).ToListAsync();

        public async Task<ICollection<T>> GetOrderByDescendingAsync() => await this.Get().OrderByDescending(t => t).ToListAsync();

        public async Task<T> FindEntityAsync(int id) => await this.ApplicationDbContext.Set<T>().FindAsync(id);

        public async Task<T> FirstOrDefaultWhereAsync(Expression<Func<T, bool>> predicate) => await this.ApplicationDbContext.Set<T>().FirstOrDefaultAsync(predicate);

        public async Task AddAsync(T t) => await this.ApplicationDbContext.Set<T>().AddAsync(t);

        public void Remove(T t) => this.ApplicationDbContext.Set<T>().Remove(t);

        public void Update(T t) => this.ApplicationDbContext.Set<T>().Update(t);

        public async Task<bool> SuccessAsync(int id) => await this.FindEntityAsync(id) != null;
    }
}

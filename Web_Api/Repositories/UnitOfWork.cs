using System.Threading.Tasks;

using Database;

using Interfaces;

namespace Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ApplicationDbContext applicationDbContext, IToDoItemRepository itemRepository)
        {
            this.applicationDbContext = applicationDbContext;

            this.ToDoItemRepository = itemRepository;
        }

        private readonly ApplicationDbContext applicationDbContext;

        public IToDoItemRepository ToDoItemRepository { get; }

        public async Task SaveChangesAsync() => await this.applicationDbContext.SaveChangesAsync();
    }
}

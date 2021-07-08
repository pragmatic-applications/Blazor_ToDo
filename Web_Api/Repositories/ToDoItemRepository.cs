using System.Threading.Tasks;

using Database;

using Domain;

using Extensions;

using Interfaces;

using Lib_BrowserPlatform;

using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class ToDoItemRepository : Repository<ToDoItem>, IToDoItemRepository
    {
        public ToDoItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PagedList<ToDoItem>> GetPagedList(EntityParameter entityParameter)
        {
            var items = await this.ApplicationDbContext.ToDoItems
            .Search(entityParameter.SearchTerm)
            .Sort(entityParameter.OrderBy)
            .ToListAsync();

            return PagedList<ToDoItem>.ToPagedList(items, entityParameter.PageNumber, entityParameter.PageSize);
        }
    }
}

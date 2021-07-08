using Domain;

namespace Interfaces
{
    public interface IToDoItemRepository : IRepository<ToDoItem>, IPagedList<ToDoItem>
    {
    }
}

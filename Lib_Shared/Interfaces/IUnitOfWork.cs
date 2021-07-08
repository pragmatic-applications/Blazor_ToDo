using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUnitOfWork
    {
        IToDoItemRepository ToDoItemRepository { get; }

        Task SaveChangesAsync();
    }
}

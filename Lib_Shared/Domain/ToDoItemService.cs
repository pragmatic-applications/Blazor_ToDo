using System.Collections.Generic;
using System.Linq;

using Interfaces;

namespace Domain
{
    public class ToDoItemService : ITaskService<ToDoItem>
    {
        private readonly Stack<List<ToDoItem>> undoStack = new();
        private readonly Stack<List<ToDoItem>> redoStack = new();


        public List<ToDoItem> ToDoItems => this.undoStack.Any() ? this.undoStack.Peek() : new List<ToDoItem>(); // Orig

        //public List<ToDoItem> UndoItems => this.undoStack.Any() ? this.undoStack.Peek() : new List<ToDoItem>();
        //public List<ToDoItem> RedoItems => this.redoStack.Any() ? this.redoStack.Peek() : new List<ToDoItem>();

        public void AddItem(ToDoItem item)
        {
            var items = new List<ToDoItem>(this.ToDoItems);
            items.Add(item);
            this.undoStack.Push(items);
        }

        public bool CanRemove => this.ToDoItems.Any(item => item.IsDone);
        public void RemoveDone()
        {
            if(this.CanRemove)
            {
                this.undoStack.Push(this.ToDoItems.Where(item => !item.IsDone).ToList());
            }
        }
        public void Clear()
        {
            this.undoStack.Clear();
            this.redoStack.Clear();
        }

        public bool CanUndo => this.undoStack.Any();
        public void Undo()
        {
            if(this.CanUndo)
            {
                var item = this.undoStack.Pop();
                this.redoStack.Push(item);
            }
        }

        public bool CanRedo => this.redoStack.Any();
        public void Redo()
        {
            if(this.CanRedo)
            {
                var item = this.redoStack.Pop();
                this.undoStack.Push(item);
            }
        }
    }
}

using System.Collections.Generic;

using Domain;

using Microsoft.EntityFrameworkCore;

namespace Database
{
    public static class SeedData
    {
        private static int Id { get; set; } = 0;

        private static List<ToDoItem> GetEntities()
        {
            var Entities = new List<ToDoItem>
            {
                new ToDoItem
                {
                    Id = ++Id,
                    Title = "Learn French",
                    IsDone = false
                },
                new ToDoItem
                {
                    Id = ++Id,
                    Title = "Research WinUI 3",
                    IsDone = false
                },
                new ToDoItem
                {
                    Id = ++Id,
                    Title = "Use Blazor with .NET MAUI",
                    IsDone = false
                },
                new ToDoItem
                {
                    Id = ++Id,
                    Title = "Learn GraphQL",
                    IsDone = false
                }
            };

            return Entities;
        }

        public static void CreateItems(this ModelBuilder modelBuilder) => modelBuilder.Entity<ToDoItem>().HasData(GetEntities());
    }
}

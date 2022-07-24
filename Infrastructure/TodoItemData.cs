using Application.Common.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class TodoItemData : ITodoItemData
    {
        private readonly List<TodoItem> _todoItems = new List<TodoItem> 
        {
            new TodoItem { Id = 1, Title = "Task 1" },
            new TodoItem { Id = 2, Title = "Task 2" }
        };

        public Task<List<TodoItem>> GetAll()
        {
            return Task.FromResult(_todoItems);
        }

        public Task<TodoItem> GetById(int Id)
        {
            return Task.FromResult(_todoItems.FirstOrDefault(x => x.Id == Id));
        }

        public Task<TodoItem> Create(TodoItem todoItem)
        {
            todoItem.Id = _todoItems.Max(x => x.Id) + 1;
            _todoItems.Add(todoItem);
            return Task.FromResult(todoItem);
        }
    }
}
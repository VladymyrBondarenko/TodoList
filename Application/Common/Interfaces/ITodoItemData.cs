using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ITodoItemData
    {
        Task<TodoItem> Create(TodoItem todoItem);
        Task<List<TodoItem>> GetAll();

        Task<TodoItem> GetById(int Id);
    }
}
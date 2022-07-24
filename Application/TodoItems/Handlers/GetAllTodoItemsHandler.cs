using Application.Common.Interfaces;
using Application.TodoItems.Queries;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TodoItems.Handlers
{
    internal class GetAllTodoItemsHandler : IRequestHandler<GetAllTodoItemsQuery, List<TodoItem>>
    {
        private readonly ITodoItemData todoItemData;

        public GetAllTodoItemsHandler(ITodoItemData todoItemData)
        {
            this.todoItemData = todoItemData;
        }

        public async Task<List<TodoItem>> Handle(GetAllTodoItemsQuery request, CancellationToken cancellationToken)
        {
            var res = await todoItemData.GetAll();
            return res;
        }
    }
}
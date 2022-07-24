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
    internal class GetTodoItemByIdHandler : IRequestHandler<GetTodoItemByIdQuery, TodoItem>
    {
        private readonly ITodoItemData todoItemData;

        public GetTodoItemByIdHandler(ITodoItemData todoItemData)
        {
            this.todoItemData = todoItemData;
        }

        public async Task<TodoItem> Handle(GetTodoItemByIdQuery request, CancellationToken cancellationToken)
        {
            var res = await todoItemData.GetById(request.Id);
            return res;
        }
    }
}

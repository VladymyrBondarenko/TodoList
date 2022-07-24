using Application.Common.Interfaces;
using Application.TodoItems.Commands;
using Domain.Entities;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TodoItems.Handlers
{
    internal class CreateTodoItemHandler : IRequestHandler<CreateTodoItemCommand, TodoItem>
    {
        private readonly ITodoItemData todoItemData;

        public CreateTodoItemHandler(ITodoItemData todoItemData)
        {
            this.todoItemData = todoItemData;
        }

        public async Task<TodoItem> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            var res = await todoItemData.Create(new TodoItem { Title = request.Title });
            return res;
        }
    }
}
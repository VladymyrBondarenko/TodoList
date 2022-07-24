using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TodoItems.Commands
{
    public record class CreateTodoItemCommand(string Title) : IRequest<TodoItem>;
}
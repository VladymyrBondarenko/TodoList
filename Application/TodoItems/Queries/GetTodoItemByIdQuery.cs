using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TodoItems.Queries
{
    public record class GetTodoItemByIdQuery(int Id) : IRequest<TodoItem>;
}

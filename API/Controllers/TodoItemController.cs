using Application.TodoItems.Commands;
using Application.TodoItems.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly IMediator mediator;

        public TodoItemController(IMediator mediator)
        {
            this.mediator = mediator;
        }   

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await mediator.Send(new GetAllTodoItemsQuery()));
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            return Ok(await mediator.Send(new GetTodoItemByIdQuery(Id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TodoItem todoItem)
        {
            var res = await mediator.Send(new CreateTodoItemCommand(todoItem.Title));
            return Ok(res);
        }
    }
}

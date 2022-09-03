using Microsoft.AspNetCore.Mvc;
using TodoAPIClass.MockData;

namespace TodoAPIClass.Controllers
{
    public class TodoController : ControllerBase
    {
       [HttpGet("todo")]
        public IActionResult GetTodos()
        {
            var todos = TodoModelMockData.Todo();
            return Ok("todos");
        }

        [HttpGet("{Id}")]
        public IActionResult InsertTodo()
        {
            var todos = TodoModelMockData.Todo();
            return Ok("todos");
        }
        [HttpDelete("todo")]
        public IActionResult DeleteTodo()
        {
            var todos = TodoModelMockData.Todo();
            return Ok("todos");
        }
    }
}

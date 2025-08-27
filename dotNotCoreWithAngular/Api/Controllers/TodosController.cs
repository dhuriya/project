using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodosController : ControllerBase
    {
        private static List<Todo> Todos = new List<Todo>
        {
            new Todo {Id = 1, Title = "Learn .Net Core", isDone=false},
            new Todo {Id = 2, Title = "Learn Angular", isDone=false},
            new Todo {Id = 3, Title = "Build a Fullstack App", isDone=false}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetTodos()
        {
            return Ok(Todos);
        }
        [HttpPost]
        public ActionResult<Todo> AddTodo(Todo todo)
        {
            todo.Id = Todos.Count + 1;
            Todos.Add(todo);
            return Ok(todo);
        }
        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodoById(int id)
        {
            var todo = Todos.FirstOrDefault(x => x.Id == id);
            if (todo == null)
                return NotFound();
            return Ok(todo);
        }
        [HttpPut("{id}")]
        public ActionResult<Todo> UpdateTodo(int id, Todo updateTodo)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
                return NotFound();
            todo.Title = updateTodo.Title;
            todo.isDone = updateTodo.isDone;

            return Ok(todo);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteTodo(int id)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
                return NotFound();
            Todos.Remove(todo);
            return NoContent();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreApi.Models;
using CoreApi.Models.DomainModel;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        #region Dependency
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        #endregion

        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return _todoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(Guid id)
        {
            var item = _todoRepository.Find(id);
            if (item == null)
                return NotFound();
            
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _todoRepository.Add(item);

            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] TodoItem item)
        {
            if (item == null || item.Id != id)
                return BadRequest();

            var todo = _todoRepository.Find(id);
            if (todo == null)
                return NotFound();

            todo.IsComplete = item.IsComplete;
            todo.Name = item.Name;

            _todoRepository.Update(todo);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _todoRepository.Remove(id);
            return new NoContentResult();
        }
    }
}
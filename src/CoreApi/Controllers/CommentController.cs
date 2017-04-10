using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreApi.Models.Repo.Interface;
using CoreApi.Models.DomainModel;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    public class CommentController : Controller
    {
        #region Dependency
        private readonly ICommentRepository _repo;

        public CommentController(ICommentRepository commentRepository)
        {
            _repo = commentRepository;
        }
        #endregion

        [HttpGet]
        public IEnumerable<Comment> GetAll()
        {
            return _repo.GetAll();
        }

        [HttpGet("{id}", Name = "GetComment")]
        public IActionResult GetById(Guid id)
        {
            var item = _repo.Get(id);
            if (item == null)
                return NotFound();

            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Comment item)
        {
            if (item == null)
                return BadRequest();

            _repo.Add(item);
            return CreatedAtRoute("Getcomment", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] Comment item)
        {
            if (item == null || item.Id != id)
                return BadRequest();

            var comment = _repo.Get(id);
            if (comment == null)
                return NotFound();

            //comment....    = item....
            //comment....    = item....

            _repo.Update(comment);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _repo.Remove(id);
            return new NoContentResult();
        }
    }
}
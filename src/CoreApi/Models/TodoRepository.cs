using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreApi.Models
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        public void Add(TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }

        public TodoItem Find(Guid key)
        {
            return _context.TodoItems.FirstOrDefault(t => t.Key == key);
        }

        public void Remove(Guid key)
        {
            var entity = _context.TodoItems.FirstOrDefault(t => t.Key == key);
            if (entity == null)
                return;
            _context.TodoItems.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TodoItem item)
        {
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }
    }
}
using CoreApi.Models.DomainModel;
using System;
using System.Collections.Generic;

namespace CoreApi.Models
{
    public interface ITodoRepository
    {
        void Add(TodoItem item);
        IEnumerable<TodoItem> GetAll();
        TodoItem Find(Guid key);
        void Remove(Guid key);
        void Update(TodoItem item);
    }
}
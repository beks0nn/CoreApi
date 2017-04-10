using CoreApi.Models.DomainModel;
using CoreApi.Models.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreApi.Models.Repo
{
    public class TodoRepository : Repository<TodoItem>, ITodoRepository
    {
        public TodoRepository(DataContext context) : base(context)
        {
        }
    }
}
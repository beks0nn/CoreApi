using CoreApi.Models.DomainModel;
using System;
using System.Collections.Generic;

namespace CoreApi.Models.Repo.Interface
{
    public interface ITodoRepository : IRepository<TodoItem>
    {
        // Extra method specific to ITodoRepository should be declared here!
    }
}
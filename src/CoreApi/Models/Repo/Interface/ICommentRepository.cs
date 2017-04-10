using CoreApi.Models.DomainModel;
using System;
using System.Collections.Generic;

namespace CoreApi.Models.Repo.Interface
{
    public interface ICommentRepository : IRepository<Comment>
    {
        // Extra method specific to ICommentRepository should be declared here!
    }
}
using System;
using System.Collections.Generic;
using RestEase;
using TheWeb.Models.Services.Interface;

namespace TheWeb.Models.Services.Implementation
{
    public class CommentService : ICommentServiceInternal
    {
        private ICommentServiceRemote api { get; set; }
        public CommentService()
        {
            api = RestClient.For<ICommentServiceRemote>("http://localhost:64792/api/Comment");
        }

        public CommentModel CreateComment(CommentModel comment)
        {
            return api.CreateCommentAsync(comment).Result;
        }

        public List<CommentModel> GetComments()
        {
            return api.GetCommentsAsync().Result;
        }
    }
}
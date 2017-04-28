using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWeb.Models.Services.Interface
{
    public interface ICommentServiceInternal
    {
        CommentModel CreateComment(CommentModel comment);
        List<CommentModel> GetComments();
    }
}

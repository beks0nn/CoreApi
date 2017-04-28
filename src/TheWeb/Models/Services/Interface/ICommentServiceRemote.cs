using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheWeb.Models.Services.Interface
{
    public interface ICommentServiceRemote
    {
        [Post]
        Task<CommentModel> CreateCommentAsync([Body] CommentModel comment);

        [Get]
        Task<List<CommentModel>> GetCommentsAsync();
    }
}

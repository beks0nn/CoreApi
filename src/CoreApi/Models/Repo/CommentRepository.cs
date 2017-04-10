using CoreApi.Models.DomainModel;
using CoreApi.Models.Repo.Interface;

namespace CoreApi.Models.Repo
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(DataContext context) : base(context)
        {
        }
    }
}

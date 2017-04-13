

namespace CoreApi.Models.DomainModel
{
    public class Comment : PersistentEntity
    {
        public string Author { get; set; }
        public string Text { get; set; }
    }
}

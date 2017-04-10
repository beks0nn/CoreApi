

namespace CoreApi.Models.DomainModel
{
    public class TodoItem : PersistentEntity
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
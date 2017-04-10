using CoreApi.Models.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //Repos
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
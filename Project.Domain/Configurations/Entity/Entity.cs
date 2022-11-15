using Project.Core.Configurations.Entity;

namespace Project.Domain.Configurations.Entity
{
    public class Entity : IEntity
    {
        public int IsActive { get; set; } = 1;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}


namespace Project.Core.Configurations.Entity
{
    public interface IEntity
    {
        int IsActive { get; set; }
        DateTime CreatedAt { get; set; }

    }
}

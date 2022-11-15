using Microsoft.AspNetCore.Identity;
using Project.Core.Configurations.Entity;

namespace Project.Domain.Entities.Identity
{
    public class User : IdentityUser<string>, IEntity
    {
        public int IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

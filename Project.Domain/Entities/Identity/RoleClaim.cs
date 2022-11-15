using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Project.Core.Configurations.Entity;

namespace Project.Domain.Entities.Identity
{
    public class RoleClaim : IdentityRoleClaim<string>
    {
      
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Project.Domain.Entities.Identity
{
    public class UserToken : IdentityUserToken<string>
    {
      
    }
}

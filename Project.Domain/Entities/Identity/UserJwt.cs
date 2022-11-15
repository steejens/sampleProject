using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Domain.Configurations.Entity;

namespace Project.Domain.Entities.Identity
{
    [Index("Token")]
    public class UserJwt : Entity
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime? RevokeDate { get; set; }
        public string? ReplacedByToken { get; set; }
        public string? ReasonRevoked { get; set; }
        public string Application { get; set; }
        [ForeignKey("User")]
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
        [NotMapped]
        public bool IsExpired => DateTime.Now >= ExpireDate;
        [NotMapped]
        public bool IsRevoked => RevokeDate != null;
        [NotMapped]
        public bool IsActive => !IsRevoked && !IsExpired;

        public TokenClaim ToTokenClaim()
        {


            var tokenClaim = new TokenClaim();
            if (!string.IsNullOrEmpty(Application))
                tokenClaim.Application = new Claim(CustomClaimTypes.Application, Application);


            return tokenClaim;
        }

    }
}

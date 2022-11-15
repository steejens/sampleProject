using System.Security.Claims;

namespace Project.Core.Models
{
    public class TokenClaim
    {
        public Claim Domain { get; set; }
        public Claim Application { get; set; }

        public TokenClaim()
        {
            
        }  
        public TokenClaim(List<Claim> claims)
        {
            this.GenerateFromList(claims);
        }
        private void GenerateFromList(List<Claim> claims)
        {
           var applicationClaim = claims?.FirstOrDefault(c => c.Type == CustomClaimTypes.Application);


           this.Application = applicationClaim;

        }
        public List<Claim> ToList()
        {
            return new List<Claim>()
            {

                Application,

            };
        }

    }
}

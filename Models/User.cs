using Microsoft.AspNetCore.Identity;
namespace AuthTEst.Models
{
    public class User: IdentityUser
    {
        public int Year { get; set; }
    }
}

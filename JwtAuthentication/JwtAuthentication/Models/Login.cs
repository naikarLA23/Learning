using System.ComponentModel.DataAnnotations;

namespace JwtAuthentication.Models.AppModels
{
    public class Login
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}

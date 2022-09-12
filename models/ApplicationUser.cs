using Microsoft.AspNetCore.Identity;

namespace masroufiServer.models
{
    public class ApplicationUser : IdentityUser
    {


        public int coins { get; set; } = 0;
        public string? genre { get; set; }

    }

    



}

   

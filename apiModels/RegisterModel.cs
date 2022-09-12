using masroufiServer.models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace masroufiServer.apiModels
{
    public class RegisterModel
    {
        public class Request
        {
            [Required]
            public string? username { get; set; }
          
            [Required]
            public string? password { get; set; }
            [Required]
            public string? genre { get; set; }
        }

        public class Response

        {
            public string? username { get; set; }


            public string? password { get; set; }

            public int? coins { get; set; }

            public string? genre { get; set; }

            public IEnumerable<IdentityError>? Errors { get; internal set; }

        }



    }
      


}

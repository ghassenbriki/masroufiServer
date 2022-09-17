using System.ComponentModel.DataAnnotations;

namespace masroufiServer.apiModels
{
    public class LoginModel
    {

        public class Request
        {

            [Required]
            public string? username { get; set; }

            [Required]
            public string? password { get; set; }

            

            
        }

        public class Response
        {
            public string? token { get; set; }
            //public IList<string>? role { get; set; }

          
        }


    }

}

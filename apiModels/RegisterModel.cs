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

            [Required]
            public string? interrets { get; set; }
           
            [Required]
            public string? ville { get; set; }
        }

        public class Response

        {
            public string? token { get; set; }

            public int? coins { get; set; }

            public string? genre { get; set; }

            public string? interrets { get; set; }

            //public IList<string>? role {get; set; }

          

        }



    }
      


}

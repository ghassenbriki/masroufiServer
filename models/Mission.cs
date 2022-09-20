using System.ComponentModel.DataAnnotations.Schema;

namespace masroufiServer.models
{
    public class Mission
    {
        public int Id { get; set; }
       
       
        public string? spot { get; set; }

        [NotMapped]
        public IFormFile? spotFile { get; set; }

        public int nbView { get; set; } = 0;

        public int nbShare { get; set; }= 0;

        public int? coinsShare { get; set; }

        public int? coinsview { get; set; }

        public string? vidSource { get; set; }

        public string? Sponsor { get; set; }

        public string? category { get; set; }


        public ICollection<ApplicationUser>? users { get; set; }



    }
}

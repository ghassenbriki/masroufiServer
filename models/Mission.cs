using System.ComponentModel.DataAnnotations.Schema;

namespace masroufiServer.models
{
    public class Mission
    {
        public int Id { get; set; }
        public ApplicationUser? user { get; set; }
        public string? spot { get; set; }

        [NotMapped]
        public IFormFile? spotFile { get; set; }

        public bool vu { get; set; } = false;

        public bool partagé { get; set; }= false;

        public int? coinsShare { get; set; }

        public int? coinsview { get; set; }
    }
}

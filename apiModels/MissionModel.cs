using System.ComponentModel.DataAnnotations;

namespace masroufiServer.apiModels
{
    public class MissionModel
    {
        [Required]
        public int? coinsShare { get; set; }

        [Required]
        public int? coinsView { get; set; }

        [Required]
        public string? Sponsor { get; set; }

        public IFormFile vidName { get; set; }
        
        [Required]
        public string? category { get; set; }

    }
}

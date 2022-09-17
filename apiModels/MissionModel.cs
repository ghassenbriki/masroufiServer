using System.ComponentModel.DataAnnotations;

namespace masroufiServer.apiModels
{
    public class MissionModel
    {
        [Required]
        public int? coinsShare { get; set; }

        [Required]
        public int? coinsView { get; set; }

        
        public IFormFile vidName { get; set; }

    }
}

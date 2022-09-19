using System.ComponentModel.DataAnnotations;

namespace masroufiServer.apiModels
{
    public class MissionModel
    {
       
        public int? coinsShare { get; set; }


        public int? coinsView { get; set; }

     
        public string? Sponsor { get; set; }

        public IFormFile vidName { get; set; }

        public string? category { get; set; }

    }
}

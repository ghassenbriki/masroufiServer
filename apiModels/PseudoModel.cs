using System.ComponentModel.DataAnnotations;

namespace masroufiServer.apiModels
{
    public class PseudoModel
    {

        [Required]
        public string? pseudo { get; set; }
    }
}

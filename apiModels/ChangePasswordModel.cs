using System.ComponentModel.DataAnnotations;

namespace masroufiServer.apiModels
{
    public class ChangePasswordModel
    {
        [Required]
        public string oldPassword { get; set; }

        [Required]
        public string newPassword { get; set; }
    }
}

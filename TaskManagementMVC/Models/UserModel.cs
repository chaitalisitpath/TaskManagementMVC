using System.ComponentModel.DataAnnotations;

namespace TaskManagementMVC.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required]
        public string? username { get; set; }

        [Required]
        public string? password { get; set; }

        public string? gender { get; set; }
    }
}

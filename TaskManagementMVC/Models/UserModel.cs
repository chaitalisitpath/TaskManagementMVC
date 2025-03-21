using System.ComponentModel.DataAnnotations;

namespace TaskManagementMVC.Models
{
    public class UserModel
    {
        public int Id { get; set; }

       
        public string? Username { get; set; }

        
        public string? Password { get; set; }

        public string? Gender { get; set; }
    }
}

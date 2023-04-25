using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MoviWed.Models
{
    public class Users : BaseModels
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]

        public string LastName { get; set; } = null!;

        [Required]

        [Display(Name = "https://cdn.pixabay.com/photo/2012/04/26/19/43/profile-42914_960_720.png")]
        public string? Avatars { get; set; }

        [Required]
        public string Phone { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        public string District { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public int Gender { get; set; }

        [DefaultValue(0)]
        public int Role { get; set; }

        [DefaultValue(1)]
        public int Status { get; set; }  
    }
}

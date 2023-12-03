using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Owner Name")]
        [StringLength(100, ErrorMessage = "Name can not Exceed 100 Characters")]
        [RegularExpression(@"^[A-Za-z\s.]+$", ErrorMessage = "Name Only Content Letter, Space and Dot")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your Email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(150)]
        public string Subject { get; set; }
        [Required]
        [StringLength (1000)]
        public string Message { get; set; }

    }
}

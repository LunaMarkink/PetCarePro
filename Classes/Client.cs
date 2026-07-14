using System.ComponentModel.DataAnnotations;

namespace PetCarePro.Classes
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(30, ErrorMessage = "The name can be at most 30 characters long.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(50, ErrorMessage = "The address can be at most 50 characters long.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        public List<Pet> Pets { get; set; } = new();
    }
}
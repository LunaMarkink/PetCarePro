using System.ComponentModel.DataAnnotations;

namespace PetCarePro.Classes
{
    public class Pet
    {
        public int PetId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "The name can be at most 100 characters long.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Species is required.")]
        [StringLength(50)]
        public string Species { get; set; } = string.Empty;

        [Required(ErrorMessage = "Breed is required.")]
        [StringLength(100)]
        public string Breed { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required.")]
        public DateTime DateOfBirth { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Gender is required.")]
        [StringLength(20)]
        public string Gender { get; set; } = string.Empty;

        [StringLength(50)]
        public string ChipNumber { get; set; } = string.Empty;

        [StringLength(1000)]
        public string MedicalHistory { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Select a owner.")]
        public int ClientId { get; set; }

        public Client Client { get; set; } = null!;
    }
}
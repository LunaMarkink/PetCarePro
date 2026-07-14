using System.ComponentModel.DataAnnotations;

namespace PetCarePro.Classes
{
    public class Pet
    {
        public int PetId { get; set; }

        [Required(ErrorMessage = "Naam is verplicht.")]
        [StringLength(100, ErrorMessage = "De naam mag maximaal 100 tekens bevatten.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Diersoort is verplicht.")]
        [StringLength(50)]
        public string Species { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ras is verplicht.")]
        [StringLength(100)]
        public string Breed { get; set; } = string.Empty;

        [Required(ErrorMessage = "Geboortedatum is verplicht.")]
        public DateTime DateOfBirth { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Geslacht is verplicht.")]
        [StringLength(20)]
        public string Gender { get; set; } = string.Empty;

        [StringLength(50)]
        public string ChipNumber { get; set; } = string.Empty;

        [StringLength(1000)]
        public string MedicalHistory { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Selecteer een eigenaar.")]
        public int ClientId { get; set; }

        public Client Client { get; set; } = null!;
    }
}
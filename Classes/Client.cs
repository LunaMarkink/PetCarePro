using System.ComponentModel.DataAnnotations;

namespace PetCarePro.Classes
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Naam is verplicht.")]
        [StringLength(100, ErrorMessage = "De naam mag maximaal 100 tekens bevatten.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adres is verplicht.")]
        [StringLength(200, ErrorMessage = "Het adres mag maximaal 200 tekens bevatten.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefoonnummer is verplicht.")]
        [Phone(ErrorMessage = "Vul een geldig telefoonnummer in.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "E-mailadres is verplicht.")]
        [EmailAddress(ErrorMessage = "Vul een geldig e-mailadres in.")]
        public string Email { get; set; } = string.Empty;

        public List<Pet> Pets { get; set; } = new();
    }
}
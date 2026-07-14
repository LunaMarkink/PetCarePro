using System.ComponentModel.DataAnnotations;

namespace PetCarePro.Classes
{
    public class Stay
    {
        public int StayId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Selecteer een huisdier.")]
        public int PetId { get; set; }

        public Pet Pet { get; set; } = null!;

        [Required(ErrorMessage = "Check-in datum is verplicht.")]
        public DateTime StartDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Check-out datum is verplicht.")]
        public DateTime EndDate { get; set; } = DateTime.Today.AddDays(1);

        [StringLength(50)]
        public string KennelNumber { get; set; } = string.Empty;

        public string Status { get; set; }
    }
    }
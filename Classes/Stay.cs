using System.ComponentModel.DataAnnotations;

namespace PetCarePro.Classes
{
    public class Stay
    {
        public int StayId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select a pet.")]
        public int PetId { get; set; }

        public Pet Pet { get; set; } = null!;

        [Required(ErrorMessage = "Check-in date is required.")]
        public DateTime StartDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Check-out date is required.")]
        public DateTime EndDate { get; set; } = DateTime.Today.AddDays(1);

        [StringLength(50)]
        public string KennelNumber { get; set; } = string.Empty;

        public string Status { get; set; }
    }
    }
using System.ComponentModel.DataAnnotations;

namespace PetCarePro.Classes
{
    public class CareSchedule
    {
        public int CareScheduleId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a pet.")]
        public int PetId { get; set; }

        public Pet Pet { get; set; } = null!;

        [Required(ErrorMessage = "Feeding instructions are required.")]
        [StringLength(200, ErrorMessage = "Feeding instructions cannot exceed 200 characters.")]
        public string Feeding { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Medication information cannot exceed 200 characters.")]
        public string Medication { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters.")]
        public string Notes { get; set; } = string.Empty;
    }
}
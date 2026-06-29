using System;

namespace PetCarePro.Classes
{
    // Care Schedule
    public class CareSchedule
    {
        public int CareScheduleId { get; set; }

        // Relationship with pet
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        public string Feeding { get; set; }
        public string Medication { get; set; }
        public string Notes { get; set; }
    }
}
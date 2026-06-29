using System;

namespace PetCarePro.Classes
{
    // Stay
    public class Stay
    {
        public int StayId { get; set; }

        // Relationship with pet
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string KennelNumber { get; set; }
        public string Status { get; set; }
    }
}
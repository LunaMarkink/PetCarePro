using System;

namespace PetCareProBlazor.Classes
{
    // Pet
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ChipNumber { get; set; }
        public string MedicalHistory { get; set; }

        // Relationship with client
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
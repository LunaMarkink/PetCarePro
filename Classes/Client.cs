namespace PetCareProBlazor.Classes
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Relationship with pets
        public List<Pet> Pets { get; set; }

        public Client()
        {
            Pets = new List<Pet>();
        }
    }
}
namespace infoAPI.Models
{
    public class Info
    {
        public int Id { get; set; } 
        public string EmailAddress { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string DateOfBirth { get; set; } = "";
        public string ContactNumber { get; set; } = "";
        public int OfficeNumber { get; set; } 
    }
}

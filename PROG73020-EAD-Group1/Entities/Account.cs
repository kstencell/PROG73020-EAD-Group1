using System.ComponentModel.DataAnnotations;


namespace PROG73020_EAD_Group1.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        private string? Password { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public string? Email { get; set; }

        // Relationships
        public List<Project_Account>? Projects_Accounts { get; set; }
    }
}

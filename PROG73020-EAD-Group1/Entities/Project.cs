using System.ComponentModel.DataAnnotations;


namespace PROG73020_EAD_Group1.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Account>? Members { get; set; }

        // Relationships
        public List<Project_Account>? Projects_Accounts { get; set; }
    }
}

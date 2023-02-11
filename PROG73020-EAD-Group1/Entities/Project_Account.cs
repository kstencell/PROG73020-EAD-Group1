

namespace PROG73020_EAD_Group1.Entities
{
    // This class represents the joining table for the many-to-many relationship between Projects and Accounts
    public class Project_Account
    {
        // foreign key for the project model
        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        // foreign key for the account model
        public int AccountId { get; set; }
        public Account? Account { get; set; }
    }
}

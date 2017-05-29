using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class Personnel
    {
        public int PersonnelID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string NationalIdentification { get; set; }
        public int JobRoleID { get; set; }
        public virtual JobRole JobRole { get; set; }
        [Required]
        [Phone]
        public string MobileNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public List<ClientCompanyCustomer> ClientCompanyCustomers { get; set; }
        public List<SalesOrganization> SalesOrganizations { get; set; }
       
    }
}
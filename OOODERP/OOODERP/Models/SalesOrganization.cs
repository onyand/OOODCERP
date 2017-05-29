using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OOODERP.Models
{
    public class SalesOrganization
    {
        public int SalesOrganizationID { get; set; }
        public string SalesOrganizationName { get; set; }
        [Display(Name = "Area Sales Manager")]
        public int PersonnelID { get; set; }
        public virtual Personnel Personnel { get; set; }
        public List<CompanyCustomerSalesOrganization> CompanyCustomerSalesOrganizations { get; set; }
    }
}
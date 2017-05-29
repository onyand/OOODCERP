using System.Collections.Generic;

namespace OOODERP.Models
{
    public class Division
    {
        public int DivisionID { get; set; }
        public string DivisionName { get; set; }
        public List<CompanyCustomerSalesOrganization> CompanyCustomerSalesOrganizations { get; set; }
    }
}
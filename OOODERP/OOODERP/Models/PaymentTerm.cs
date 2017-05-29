using System.Collections.Generic;

namespace OOODERP.Models
{
    public class PaymentTerm
    {
        public int PaymentTermID { get; set; }
        public string Terms { get; set; }
        public string TermsDescription { get; set; }
        public int NumberOfDays { get; set; }
        public List<ClientCompanyCustomer> ClientCompanyCustomers { get; set; }
        public List<CompanyCustomerSalesOrganization> CompanyCustomerSalesOrganizations { get; set; }
    }
}
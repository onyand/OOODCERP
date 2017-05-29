using System.Collections.Generic;

namespace OOODERP.Models
{
    public class CreditCheckStatus
    {
        public int CreditCheckStatusID { get; set; }
        public string CreditCheckStatusName { get; set; }
        public List<ClientCompanyCustomerCreditLimit> ClientCompanyCustomerCreditLimits { get; set; }
        public List<CompanyCustomerSalesOrganizationCreditLimit> CompanyCustomerSalesOrganizationCreditLimits { get; set; }

    }
}
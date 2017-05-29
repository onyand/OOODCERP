namespace OOODERP.Models
{
    public class CompanyCustomerSalesOrganizationCreditLimit
    {
        public int CompanyCustomerSalesOrganizationCreditLimitID { get; set; }
        public int CompanyCustomerSalesOrganizationID { get; set; }
        public virtual CompanyCustomerSalesOrganization CompanyCustomerSalesOrganization { get; set; }
        public int CreditCheckStatusID { get; set; }
        public virtual CreditCheckStatus CreditCheckStatus { get; set; }
        public decimal OrderCreditLimitAmount { get; set; }
        public decimal CreditLimitAmount { get; set; }
        public decimal CreditLimitTolerance { get; set; }
    }
}
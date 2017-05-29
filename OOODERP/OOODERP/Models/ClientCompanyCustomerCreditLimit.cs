namespace OOODERP.Models
{
    public class ClientCompanyCustomerCreditLimit
    {
        public int ClientCompanyCustomerCreditLimitID { get; set; }
        public int ClientCompanyCustomerID { get; set; }
        public virtual ClientCompanyCustomer ClientCompanyCustomer { get; set; }
        public int CreditCheckStatusID { get; set; }
        public virtual CreditCheckStatus CreditCheckStatus { get; set; }
        public decimal OrderCreditLimitAmount { get; set; }
        public decimal CreditLimitAmount { get; set; }
        public decimal CreditLimitTolerance { get; set; }
    }
}
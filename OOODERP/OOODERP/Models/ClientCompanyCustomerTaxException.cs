namespace OOODERP.Models
{
    public class ClientCompanyCustomerTaxException
    {
        public int ClientCompanyCustomerTaxExceptionID { get; set; }
        //[Index("IX_CustomerTaxException",1, IsUnique =true)]
        public int ClientCompanyCustomerID { get; set; }
        public virtual ClientCompanyCustomer ClientCompanyCustomer { get; set; }
        //[Index("IX_CustomerTaxException",2, IsUnique = true)]
        public int TaxProfileID { get; set; }
        public virtual TaxProfile TaxProfile { get; set; }
    }
}
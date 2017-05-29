namespace OOODERP.Models
{
    public class SaleItemCompanyCustomerSalesOrganizationTaxException
    {
        public int SaleItemCompanyCustomerSalesOrganizationTaxExceptionID { get; set; }
        //[Index("IX_SaleItemSalesOrgTaxProfile",1, IsUnique =true)]
        public int SaleItemCompanyCustomerSalesOrganizationID { get; set; }
        public virtual SaleItemCompanyCustomerSalesOrganization SaleItemCompanyCustomerSalesOrganization { get; set; }
        //[Index("IX_SaleItemSalesOrgTaxProfile",2, IsUnique = true)]
        public int TaxProfileID { get; set; }
        public virtual TaxProfile TaxProfile { get; set; }


    }
}
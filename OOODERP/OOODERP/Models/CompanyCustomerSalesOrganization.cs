using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OOODERP.Models
{
    public class CompanyCustomerSalesOrganization
    {
        public int CompanyCustomerSalesOrganizationID { get; set; }
        //[Index("IX_CustomerSalesOrganizationDivisionChannel", 1, IsUnique = true)]
        public int ClientCompanyCustomerID { get; set; }
        public virtual ClientCompanyCustomer ClientCompanyCustomer { get; set; }
        //[Index("IX_CustomerSalesOrganizationDivisionChannel", 2, IsUnique = true)]
        public int SalesOrganizationID { get; set; }
        public virtual SalesOrganization SalesOrganization { get; set; }
        //[Index("IX_CustomerSalesOrganizationDivisionChannel", 3, IsUnique = true)]
        public int DivisionID { get; set; }
        public virtual Division Division { get; set; }
        //[Index("IX_CustomerSalesOrganizationDivisionChannel", 4, IsUnique = true)]
        public int ChannelID { get; set; }
        public virtual Channel Channel { get; set; }
        [Display (Name = "Sales Manager")]
        public int PersonnelID { get; set; }
        public virtual Personnel Personnel { get; set; }
        [Display (Name= "Transaction Currency")]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public int PaymentTermID { get; set; }
        public virtual PaymentTerm PaymentTerm { get; set; }
        public List<SaleItemCompanyCustomerSalesOrganization> SaleItemCompanyCustomerSalesOrganizations { get; set; }
        public List<SalesOrderHeader> SalesOrders { get; set; }
        public List<CompanyCustomerSalesOrganizationCreditLimit> CompanyCustomerSalesOrganizationCreditLimits { get; set; }

    }
}
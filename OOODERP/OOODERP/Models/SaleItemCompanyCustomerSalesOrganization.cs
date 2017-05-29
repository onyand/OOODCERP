using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class SaleItemCompanyCustomerSalesOrganization
    {
        public int SaleItemCompanyCustomerSalesOrganizationID { get; set; }
        //[Index("IX_SaleItemSalesOrganizationPlant",1,IsUnique = true)]
        public int SaleItemID { get; set; }
        public virtual SaleItem SaleItem { get; set; }
        //[Index("IX_SaleItemSalesOrganizationPlant", 2, IsUnique = true)]
        public int CompanyCustomerSalesOrganizationID { get; set; }
        public virtual CompanyCustomerSalesOrganization CompanyCustomerSalesOrganization { get; set; }
        //[Index("IX_SaleItemSalesOrganizationPlant", 3, IsUnique = true)]
        [Display(Name= "Distribution Plant")]
        public int ItemClientCompanyPlantID { get; set; }
        public virtual ItemClientCompanyPlant ItemClientCompanyPlant { get; set; }
        public List<SalesOrderLine> SalesOrderLines { get; set; }
        public List<SaleItemCompanyCustomerSalesOrganizationTaxException> SaleItemCompanyCustomerSalesOrganizationTaxExceptions { get; set; }
    }
}
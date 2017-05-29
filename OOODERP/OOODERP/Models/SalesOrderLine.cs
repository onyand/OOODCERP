using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class SalesOrderLine
    {
        public int SalesOrderLineID { get; set; }
        //[Index("IX_SalesOrderLineOrganizationItemUserDevice", 1, IsUnique = true)]
        public int DeviceSalesOrderLineID { get; set; }
        //[Index("IX_SalesOrderLineOrganizationItemUserDevice", 2, IsUnique = true)]
        public int SalesOrderHeaderID { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        //[Index("IX_SalesOrderLineOrganizationItemUserDevice", 3, IsUnique = true)]
        public int DeviceSalesOrderHeaderID { get; set; }
        //[Index("IX_SalesOrderLineOrganizationItemUserDevice", 4, IsUnique = true)]
        public int SaleItemCompanyCustomerSalesOrganizationID { get; set; }
        public virtual SaleItemCompanyCustomerSalesOrganization SaleItemCompanyCustomerSalesOrganization { get; set; }
        [ScaffoldColumn(false)]
        //[Index("IX_SalesOrderLineOrganizationItemUserDevice", 5, IsUnique = true)]
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public string ItemDescription { get; set; }
        //[Index("IX_SalesOrderLineOrganizationItemUserDevice", 6, IsUnique = true)]
        [ScaffoldColumn(false)]
        public int UserID { get; set; }
        public virtual User User { get; set; }
        //[Index("IX_SalesOrderLineOrganizationItemUserDevice", 7, IsUnique = true)]
        [MaxLength(40)]
        public string DeviceIdentification { get; set; }
        //[Index("IX_SalesOrderLineOrganizationItemUserDevice", 8, IsUnique = true)]
        [MaxLength(40)]
        public string IMEINumber { get; set; }
        private DateTime CreateDate = DateTime.Now;
        public DateTime OrderDate
        {
            get { return OrderDate; }
            set { OrderDate = value; }
        }
        [ScaffoldColumn(false)]
        public int ItemUnitOfMeasureID { get; set; }
        public virtual ItemUnitOfMeasure ItemUnitOfMeasure { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ManualPrice { get; set; }
        public decimal SuggestedSellingQuantity { get; set; }
        public decimal AvailableStock { get; set; }
        public decimal OrderedQuantity { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal ItemTax { get; set; }
        public decimal ItemGrossValue { get; set; }
        public decimal ItemNetValue { get; set; }
        public List<SalesOrderLineAdjustment> SalesOrderLineAdjustments { get; set; }
        public List<SalesOrderLineTaxBreakDown> SalesOrderLineTaxBreakDowns { get; set; }
        public decimal OriginalOrderQuantity { get; set; }
        public decimal ShippedQuantity { get; set; }
    }
}
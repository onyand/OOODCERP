namespace OOODERP.Models
{
    public class SalesOrderLineAdjustment
    {
        public int SalesOrderLineAdjustmentID { get; set; }
        //[Index("IX_SalesOrderLineAdjustmentOrganizationItemUserDevice", 1, IsUnique = true)]
        public int DeviceSalesOrderLineAdjustmentID { get; set; }     
        //[Index("IX_SalesOrderLineAdjustmentOrganizationItemUserDevice", 2, IsUnique = true)]
        public int SalesOrderHeaderID { get; set; }
        public virtual SalesOrderHeader SalesOrderHeaders { get; set; }
        //[Index("IX_SalesOrderLineAdjustmentOrganizationItemUserDevice", 3, IsUnique = true)]
        public int DeviceSalesOrderHeaderID { get; set; }
        //[Index("IX_SalesOrderLineAdjustmentOrganizationItemUserDevice", 4, IsUnique = true)]
        public int SalesOrderLineID { get; set; }
        public virtual SalesOrderLine SalesOrderLine { get; set; }
        //[Index("IX_SalesOrderLineAdjustmentOrganizationItemUserDevice", 5, IsUnique = true)]
        public int DeviceSalesOrderLineID { get; set; }
        //[Index("IX_SalesOrderLineAdjustmentOrganizationItemUserDevice", 6, IsUnique = true)]
        public int PriceRuleID { get; set; }
        public virtual PriceRule PriceRule { get; set; }
        public string PriceRuleDescription { get; set; }
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public int SaleItemCompanyCustomerSalesOrganizationID { get; set; }
        public virtual SaleItemCompanyCustomerSalesOrganization SaleItemCompanyCustomerSalesOrganization { get; set; }
        public decimal FreeOrSampleItemUnitPrice { get; set; }
        public decimal AdjustmentQuantity { get; set; }
        public decimal SampleQuantity { get; set; }
        public decimal AdjustmentAmount { get; set; }
        public string AdjustmentExpression { get; set; }
    }
}
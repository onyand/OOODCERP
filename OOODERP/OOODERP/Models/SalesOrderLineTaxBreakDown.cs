namespace OOODERP.Models
{
    public class SalesOrderLineTaxBreakDown
    {
        public int SalesOrderLineTaxBreakDownID { get; set; }
        public int DeviceSalesOrderLineTaxBreakDownID { get; set; }
        public int SalesOrderHeaderID { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        public int DeviceSalesOrderHeaderID { get; set; }
        public int SalesOrderLineID { get; set; }
        public virtual SalesOrderLine SalesOrderLine { get; set; }
        public int DeviceSalesOrderLineID { get; set; }
        public double SaleItemTaxExceptionTotal { get; set; }
        public double SaleItemJurisdictionTaxExceptionTotal { get; set; }
        public double SaleItemTaxRegimeBasicDataTotal { get; set; }
        public double ClientCustomerTaxRegimeBasicDataTotal { get; set; }
        public double ClientCustomerJurisdictionTaxExceptionTotal { get; set; }
        public double ClientCustomerTaxExceptionTotal { get; set; }
        public double BasicTaxOnly { get; set; }
        
    }
}
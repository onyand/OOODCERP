using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class SalesOrderHeader
    {
        public int SalesOrderHeaderID { get; set; }
        //[Index("IX_SalesOrderHeaderOrganizationUserHardwareId", 1, IsUnique = true)]
        public int DeviceSalesOrderHeaderID { get; set; }
        //[Index("IX_SalesOrderHeaderOrganizationUserHardwareId", 2, IsUnique = true)]
        public int CompanyCustomerSalesOrganizationID { get; set; }
        public virtual CompanyCustomerSalesOrganization CompanyCustomerSalesOrganization { get; set; }
        //[Index("IX_SalesOrderHeaderOrganizationUserHardwareId", 3, IsUnique = true)]
        [ScaffoldColumn(false)]
        public int UserID { get; set; }
        public virtual User User { get; set; }
        //[Index("IX_SalesOrderHeaderOrganizationUserHardwareId", 4, IsUnique = true)]     
        [MaxLength(40)]
        public string DeviceIdentification { get; set; }
        //[Index("IX_SalesOrderHeaderOrganizationUserHardwareId", 5, IsUnique = true)]
        [MaxLength(40)]
        public string IMEINumber { get; set; }
        public int CustomerID { get; set; }
        //[Index("IX_SalesOrderHeaderOrganizationUserHardwareId", 6, IsUnique = true)]
        public virtual Customer Customer { get; set; }
        private DateTime CreateDate = DateTime.Now;
        public DateTime OrderDate
        {
            get { return OrderDate; }
            set { OrderDate = value; }
        }
        public decimal InvoiceGrossValue { get; set; }
        public decimal ItemValueDiscount { get; set; }
        public decimal ItemQuantityDiscount { get; set; }
        public decimal ItemSampleQuantity { get; set; }
        public decimal NetInvoiceValue { get; set; }
        public decimal InvoiceTax { get; set; }
        public decimal CustomerBalance { get; set; }
        public decimal InvoiceLevelDiscount { get; set; }
        public decimal TotalDiscount { get; set; }
        public string UploadStatus { get; set; }
        public int SalesOrderStatusID { get; set; }
        public virtual SalesOrderStatus SalesOrderStatus { get; set; }
        public List<SalesOrderLine> SalesOrderLines { get; set; }
        public List<SalesOrderLineAdjustment> SalesOrderLineAdjustments { get; set; }
        public List<SalesOrderLineTaxBreakDown> SalesOrderLineTaxBreakDowns { get; set; }
        public List<SalesOrderInvoice> SalesOrderInvoices { get; set; }

    }
}
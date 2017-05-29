using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class SalesOrderInvoicePayment
    {
        public int SalesOrderInvoicePaymentID { get; set; }
        public int DeviceSalesOrderInvoicePaymentID { get; set; }
        public int SalesOrderInvoiceID { get; set; }
        public virtual SalesOrderInvoice SalesOrderInvoice { get; set; }
        public int DeviceSalesOrderInvoiceID { get; set; }
        public decimal PaymentMethodID { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        [Required]
        [MaxLength(40)]
        //[Index("IX_InvoicePaymentReference", IsUnique = true)]
        public string ReferenceNumberOrComment { get; set; }
        public decimal AmountPaid { get; set; }

    }
}
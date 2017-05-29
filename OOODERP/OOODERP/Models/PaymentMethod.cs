using System.Collections.Generic;

namespace OOODERP.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodID { get; set; }
        public string Method { get; set; }
        public string MethodDescription { get; set; }
        public List<SalesOrderInvoicePayment> SalesOrderInvoicePayments { get; set; }

    }
}
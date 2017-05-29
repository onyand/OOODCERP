using System.Collections.Generic;

namespace OOODERP.Models
{
    public class InvoiceStatus
    {
        public int InvoiceStatusID { get; set; }
        public string InvoiceStatusName { get; set; }
        public string InvoiceStatusDescription { get; set; }
        public List<SalesOrderInvoice> SalesOrderInvoices { get; set; }

    }
}
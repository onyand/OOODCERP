using System;
using System.Collections.Generic;

namespace OOODERP.Models
{
    public class SalesOrderInvoice
    {
        public int SalesOrderInvoiceID { get; set; }
        public int DeviceSalesOrderInvoiceID { get; set; }
        public int SalesOrderHeaderID { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        public int DeviceSalesOrderHeaderID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceAmount { get; set; }
        public int InvoiceStatusID { get; set; }
        public virtual InvoiceStatus InvoiceStatus { get; set; }
        public List<SalesOrderInvoicePayment> SalesOrderInvoicePayments { get; set; }

    }
}
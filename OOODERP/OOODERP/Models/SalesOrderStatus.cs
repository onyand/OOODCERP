using System.Collections.Generic;

namespace OOODERP.Models
{
    public class SalesOrderStatus
    {
        public int SalesOrderStatusID { get; set; }
        public string SalesOrderStatusName { get; set; }
        public string SalesOrderStatusDescription { get; set; }
        public List<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
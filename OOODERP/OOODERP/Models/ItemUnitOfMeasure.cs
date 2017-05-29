using System.Collections.Generic;

namespace OOODERP.Models
{
    public class ItemUnitOfMeasure
    {
        public int ItemUnitOfMeasureID { get; set; }
        public string ItemUnitOfMeasureSymbol { get; set; }
        public string ItemUnitOfMeasureDescription { get; set; }
        public List<Item> Items { get; set; }
        public List<SalesOrderLine> SalesOrderLines { get; set; }

    }
}
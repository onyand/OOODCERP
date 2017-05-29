using System.Collections.Generic;

namespace OOODERP.Models
{
    public class ItemDimensionUnit
    {
        public int ItemDimensionUnitID { get; set; }
        public string ItemDimensionUnitSymbol { get; set; }
        public string ItemDimensionUnitDescription { get; set; }
        public List<Item> Items { get; set; }
    }
}
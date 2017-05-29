using System.Collections.Generic;

namespace OOODERP.Models
{
    public class ItemWeightUnit
    {
        public int ItemWeightUnitID { get; set; }
        public string ItemWeightSymbol { get; set; }
        public string ItemWeightUnitDescription { get; set; }
        public List<Item> Items { get; set; }
    }
}
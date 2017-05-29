using System.Collections.Generic;

namespace OOODERP.Models
{
    public class ItemVolumeUnit
    {
        public int ItemVolumeUnitID { get; set; }
        public string VolumeUnitSymbol { get; set; }
        public string VolumeUnitDescription { get; set; }
        public List<Item> Items { get; set; }
    }
}
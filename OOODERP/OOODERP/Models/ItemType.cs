using System.Collections.Generic;

namespace OOODERP.Models
{
    public class ItemType
    {
        public int ItemTypeID { get; set; }
        public string ItemTypeDescription { get; set; }
        public List<Item> Items { get; set; }
    }
}
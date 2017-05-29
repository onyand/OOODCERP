using System.Collections.Generic;

namespace OOODERP.Models
{
    public class ItemStatus
    {
        public int ItemStatusID { get; set; }
        public string ItemStatusDescription { get; set; }
        public List<Item> Items { get; set; }
    }
}
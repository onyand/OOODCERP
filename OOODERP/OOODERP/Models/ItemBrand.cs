using System.Collections.Generic;

namespace OOODERP.Models
{
    public class ItemBrand
    {
        public int ItemBrandID { get; set; }
        public string ItemBrandName { get; set; }
        public List<Item> Items { get; set; }
    }
}
using System.Collections.Generic;

namespace OOODERP.Models
{
    public class MakeBuyGoods
    {
        public int MakeBuyGoodsID { get; set; }
        public string SourceOfGoods { get; set; }
        public string SourceOfGoodsDescription { get; set; }
        public List<ItemClientCompanyPlant> ItemClientCompanyPlants { get; set; }
    }
}
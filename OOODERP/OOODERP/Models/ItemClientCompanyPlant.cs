using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace OOODERP.Models
{
    public class ItemClientCompanyPlant
    {
        public int ItemClientCompanyPlantID { get; set; }
        //[Index("IX_ItemClientCompanyPlant", 1, IsUnique = true)]
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        //[Index("IX_ItemClientCompanyPlant", 2, IsUnique = true)]
        public int ClientCompanyPlantID { get; set; }
        public virtual ClientCompanyPlant ClientCompanyPlant { get; set; }
        [Display(Name = "Plant Item Status")]
        public int ItemStatusID { get; set; }
        public virtual ItemStatus ItemStatus { get; set; }
        public int MakeBuyGoodsID { get; set; }
        public virtual MakeBuyGoods MakeBuyGoods { get; set; }
        public string ABCClassification { get; set; }
        public decimal ReorderLevelQuantity { get; set; }
        public decimal SafetyStockQuantity { get; set; }
        public List<ItemClientCompanyPlantStorageLocation> ItemClientCompanyPlantStorageLocations { get; set; }
        public List<SaleItemCompanyCustomerSalesOrganization> SaleItemCompanyCustomerSalesOrganizations { get; set; }
    }
}
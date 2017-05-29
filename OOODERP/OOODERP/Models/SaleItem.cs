using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class SaleItem
    {
        public int SaleItemID { get; set; }
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        [Display (Name="Selling Unit Of Measure")]
        public int ItemUnitOfMeasureID { get; set; }
        public virtual ItemUnitOfMeasure ItemUnitOfMeasure { get; set; }
        public int NumberOfPieces { get; set; }
        public List<SaleItemPrice> SaleItemPrices { get; set; }


        
    }
}
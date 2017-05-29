using System;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class SaleItemPrice
    {
        public int SaleItemPriceID { get; set; }
        //[Index("IX_SaleItemIDCountryID", 1, IsUnique=true)]
        public int SaleItemID { get; set; }
        public virtual SaleItem SaleItem { get; set; }
        public decimal Price { get; set; }
        [Display(Name="Price Currency")]  
        //[Index("IX_SaleItemIDCountryID", 2, IsUnique=true)]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public DateTime PriceEffectivityDate { get; set; }
        public DateTime PriceExpiryDate { get; set; }
        

    }
}
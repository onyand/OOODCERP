using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOODERP.Models
{
    public class TaxCode
    {
        public int TaxCodeID { get; set; }
        //[Index("IX_CountryTaxCode",1, IsUnique = true)]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        [StringLength(40)]
        //[Column(TypeName = "VARCHAR")]
        //[Index("IX_CountryTaxCode",2, IsUnique = true)]
        public string TaxCodeName { get; set; }
        public string TaxCodeDescription { get; set; }
        public decimal TaxRate { get; set; }
        public List<ItemTaxCode> ItemTaxCodes { get; set; }
        public List<TaxProfile> TaxProfiles { get; set; }
    }
}
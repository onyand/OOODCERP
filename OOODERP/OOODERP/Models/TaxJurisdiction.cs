namespace OOODERP.Models
{
    public class TaxJurisdiction
    {
        public int TaxJurisdictionID { get; set; }
        //[Index("IX_Jurisdiction_Country_Region1_Region2", 1, IsUnique = true)]
        public int CountryCityID { get; set; }
        public virtual CountryCity CountryCity { get; set; }
        //[Index("IX_Jurisdiction_Country_Region1_Region2", 2, IsUnique = true)]
        public int CountryCityRegion1ID { get; set; }
        public virtual CountryCityRegion1 CountryCityRegion1 { get; set; }
        //[Index("IX_Jurisdiction_Country_Region1_Region2", 3, IsUnique = true)]
        public int CountryCityRegion2ID { get; set; }
        public virtual CountryCityRegion2 CountryCityRegion2 { get; set; }
        //[Index("IX_Jurisdiction_Country_Region1_Region2", 4, IsUnique = true)]
        public int TaxCodeID { get; set; }
        public virtual TaxCode TaxCode { get; set; }

    }
}
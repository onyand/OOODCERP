namespace OOODERP.Models
{
    public class TaxBasicConfiguration
    {
        public int TaxBasicConfigurationID { get; set; }
        public int TaxCodeID { get; set; }
        //[Index ("IX_TaxApplicationOrder", 1, IsUnique =true)]
        public int TaxApplicationOrder { get; set; }
        public virtual TaxCode TaxCode { get; set; }
    }
}
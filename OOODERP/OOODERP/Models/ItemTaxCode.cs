namespace OOODERP.Models
{
    public class ItemTaxCode
    {
        public int ItemTaxCodeID { get; set; }
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public int TaxCodeID { get; set; }
        public virtual TaxCode TaxCode { get; set; }

    }
}
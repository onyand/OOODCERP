namespace OOODERP.Models
{
    public class ItemClientCompanyPlantStorageLocationCurrentStock
    {
        public int ItemClientCompanyPlantStorageLocationCurrentStockID { get; set; }
        public int ItemClientCompanyPlantStorageLocationID { get; set; }
        public virtual ItemClientCompanyPlantStorageLocation ItemClientCompanyPlantStorageLocation { get; set; }
        public decimal AvailableStock { get; set; }
        public decimal AllocatedStock { get; set; }
    }
}
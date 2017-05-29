namespace OOODERP.Models
{
    public class UserItemClientCompanyPlantStorageLocation
    {
        public int UserItemClientCompanyPlantStorageLocationID { get; set; }
        public int ItemClientCompanyPlantStorageLocationID { get; set; }
        public virtual ItemClientCompanyPlantStorageLocation ItemClientCompanyPlantStorageLocation { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
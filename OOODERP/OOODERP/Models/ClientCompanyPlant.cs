namespace OOODERP.Models
{
    public class ClientCompanyPlant
    {
        public int ClientCompanyPlantID { get; set; }
        public int ClientCompanyID { get; set; }
        public virtual ClientCompany ClientCompany { get; set; }
        public string PlantName { get; set; }
        public string PlantNameDescription { get; set; }
        
    }
}
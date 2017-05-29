using System.Collections.Generic;

namespace OOODERP.Models
{
    public class ClientCompany
    {
        public int ClientCompanyID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public string ClientCompanyName { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public List<ClientCompanyPlant> ClientCompanyPlants { get; set; }
    }
}
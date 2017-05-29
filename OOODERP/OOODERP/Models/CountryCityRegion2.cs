using System.Collections.Generic;

namespace OOODERP.Models
{
    public class CountryCityRegion2
    {
        public int CountryCityRegion2ID { get; set; }
        public int CountryCityID { get; set; }
        public virtual CountryCity CountryCity { get; set; }
        public string Region2 { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
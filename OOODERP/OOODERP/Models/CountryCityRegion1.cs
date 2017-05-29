using System.Collections.Generic;

namespace OOODERP.Models
{
    public class CountryCityRegion1
    {
        public int CountryCityRegion1ID { get; set; }
        public int CountryCityID { get; set; }
        public virtual CountryCity CountryCity { get; set; }
        public string Region1 { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
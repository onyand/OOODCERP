using System.Collections.Generic;

namespace OOODERP.Models
{
    public class CountryCity
    {
        public int CountryCityID { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public string City { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Bank> Banks { get; set; }
        public List<CountryCityRegion1> CountryCityRegion1 { get; set; }
        public List<CountryCityRegion2> CountryCityRegion2 { get; set; }
    }
}
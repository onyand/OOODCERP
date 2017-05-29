using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OOODERP.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        [Required]
        [MinLength(2), MaxLength(2)]
        public string CountryCode { get; set; }
         [Required]
        public string CountryName { get; set; }
        public virtual List<ClientCompany> ClientCompanies { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Bank>  Banks { get; set; }
        public List<SaleItemPrice> SaleItemPrices { get; set; }
        public List<CountryCity> CountryCities { get; set; }
        public List<CountryCurrency> CountryCurrencies { get; set; }
    }
}
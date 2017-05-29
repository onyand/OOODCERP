using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class CountryCurrency
    {
        public int CountryCurrencyID { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        [Required]
        [MinLength(3), MaxLength(3)]
        public string CurrencyCode { get; set; }
        [Required]
        public string CurrencyName { get; set; }
        public List<CustomerBank> CustomerBanks { get; set; }
    }
}
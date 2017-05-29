using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class Language
    {
        public int LanguageID { get; set; }
        [Required, MinLength(2), MaxLength(2)]
        public string LanguageCode { get; set; }
        [Required]
        public string LanguageName { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
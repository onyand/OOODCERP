using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class Bank
    {
        public int BankID { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public string NameOfBank { get; set; }
        public string BankBranch { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PostalAddress { get; set; }
        public string PostalCode { get; set; }
        public int CountryCityID { get; set; }
        public virtual CountryCity CountryCity { get; set; }
        [MinLength(8), MaxLength(11)]
        public string SwiftCode { get; set; }
        public string IBANNumber {get;set;}
        public string Comments { get; set; }
        public List<CustomerBank> CustomerBanks { get; set; }
    }
}
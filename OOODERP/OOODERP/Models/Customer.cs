using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        [Required]
        public string PostalAddress1 { get; set; }
        public string PostalCode1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalCode2 { get; set; }
        public int CountryCityID { get; set; }
        public virtual CountryCity CountryCity { get; set; }
        [Required]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        [Required]
        public int LanguageID { get; set; }
        public virtual Language Language { get; set; }
        [Required]
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        [Required]
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        [EmailAddress]
        public string Email1 { get; set; }
        [EmailAddress]
        public string Email2 { get; set; }
        public string TaxNumber1 { get; set; }
        public string TaxNumber2 { get; set; }
        private DateTime CreateDate = DateTime.Now;
        [ScaffoldColumn (false)]
        public DateTime CreationDate { 
            get { return CreateDate; } 
            set { CreateDate = value; } 
        }
        public int CountryCityRegion1ID { get; set; }
        public virtual CountryCityRegion1 CountryCityRegion1 { get; set; }
        public int CountryCityRegion2ID { get; set; }
        public virtual CountryCityRegion2 CountryCityRegion2 { get; set; }
        public int Classification1ID { get; set; }
        public virtual Classification1 Classification1 { get; set; }
        public int Classification2ID { get; set; }
        public virtual Classification2 Classification2 { get; set; }
        public List<CustomerBank> CustomerBanks { get; set; }
        public List<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace OOODERP.Models
{
    public class TaxProfile
    {
        public int TaxProfileID { get; set; }
        public String ProfileName { get; set; }
        public Boolean BasicTax { get; set; }
        public Boolean JurisdictionTax { get; set; }
        public int TaxCodeID { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public List<ClientCompanyCustomerTaxException> ClientCompanyCustomerTaxExceptions { get; set; }
    }
}
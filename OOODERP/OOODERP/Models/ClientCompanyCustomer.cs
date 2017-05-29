using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class ClientCompanyCustomer
    {
        public int ClientCompanyCustomerID { get; set; }
        //[Index("IX_ClientCompanyCustomer",1, IsUnique = true)]
        public int ClientCompanyID { get; set; }
        public virtual ClientCompany ClientCompany { get; set; }
        //[Index("IX_ClientCompanyCustomer",2, IsUnique = true)]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        [Display (Name = "Account Manager")]
        public int PersonnelID { get; set; }
        public virtual Personnel Personnel { get; set; }
        [Display (Name = "Our Account at Customer")]
        public string AccountIDAtCustomer { get; set; }
        public int PaymentTermID { get; set; }
        public virtual PaymentTerm PaymentTerm { get; set; }
        public string ContactPersonAtCustomer { get; set; }
        public List<ClientCompanyCustomerTaxException> ClientCompanyCustomerTaxExceptions { get; set; }
        public List<ClientCompanyCustomerCreditLimit> ClientCompanyCustomerCreditLimits { get; set; }
    }
}
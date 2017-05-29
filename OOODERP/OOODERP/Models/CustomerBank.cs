using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class CustomerBank
    {
        public int CustomerBankID { get; set; }
        //[Index("IX_CustomerIDBankIDCountryCurrency", 1,IsUnique = true)]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        //[Index("IX_CustomerIDBankIDCountryCurrency", 2, IsUnique = true)]
        public int BankID { get; set; }
        public virtual Bank Bank { get; set; }
        //[Index("IX_CustomerIDBankIDCountryCurrency", 3, IsUnique = true)]
        public int CountryCurrencyID { get; set; }
        public virtual CountryCurrency CountryCurrency { get; set; }
      
        public string BankAccountNumber { get; set; }
        [Required]
        public string BankAccountName { get; set; }
        public string SpecialInstructions { get; set; }
    }
}
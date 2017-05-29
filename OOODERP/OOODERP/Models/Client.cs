using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        [Required (ErrorMessage ="ClientNameRequired")]
        [Display(Name= "ClientName")]
        public string ClientName { get; set; }
        public List<ClientCompany> ClientCompanies { get; set; }
    }
}
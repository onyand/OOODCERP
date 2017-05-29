using System.Collections.Generic;

namespace OOODERP.Models
{
    public class Channel
    {
        public int ChannelID { get; set; }
        public string ChannelName { get; set; }
        public List<CompanyCustomerSalesOrganization> CompanyCustomerSalesOrganizations { get; set; }
    }
}
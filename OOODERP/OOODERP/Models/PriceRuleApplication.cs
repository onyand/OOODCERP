using System.Collections.Generic;

namespace OOODERP.Models
{
    public class PriceRuleApplication
    {
        public int PriceRuleApplicationID { get; set; }
        public string PriceRuleApplicationName { get; set; }
        public string PriceRuleApplicationDescription { get; set; }
        public List<PriceRuleType> PriceRuleTypes { get; set; }

    }
}
namespace OOODERP.Models
{
    public class PriceRuleType
    {
        public int PriceRuleTypeID { get; set; }
        public string PriceRuleTypeCode { get; set; }
        public string PriceRuleTypeDescription { get; set; }
        public string PriceRuleExpression { get; set; }
        public int PriceRuleApplicationID { get; set; }
        public virtual PriceRuleApplication PriceRuleApplication { get; set; }
        
    }
}
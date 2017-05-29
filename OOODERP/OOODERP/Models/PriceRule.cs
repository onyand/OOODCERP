using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class PriceRule
    {
        public int PriceRuleID { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 1, IsUnique = true)]
        public int PriceRuleTypeID { get; set; }
        public virtual PriceRuleType PriceRuleType { get; set; }
        public string PriceRuleDescription { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountQuantity { get; set; }
        public decimal SampleGoodsQuantity { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 2, IsUnique = true)]
        public DateTime EffectiveDate { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 3, IsUnique = true)]
        public DateTime ExpiryDate { get; set; }
        public Boolean MarkAsExpired { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 4, IsUnique = true)]
        [StringLength(100)]
        public String PriceRuleQualification1Expression { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 5, IsUnique = true)]
        [StringLength(100)]
        public String PriceRuleQualification2Expression { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 6, IsUnique = true)]
        [StringLength(100)]
        public String PriceRuleApplication1Expression { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 7, IsUnique = true)]
        [StringLength(100)]
        public String PriceRuleApplication2Expression { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 8, IsUnique = true)]
        [StringLength(100)]
        public String PriceRuleExclusion1Expression { get; set; }
        //[Index("IX_PriceRuleDatesExpression", 9, IsUnique = true)]
        [StringLength(100)]
        public String PriceRuleExclusion2Expression { get; set; }
        public List<SalesOrderLineAdjustment> SalesOrderLineAdjustments { get; set; }
    }
}
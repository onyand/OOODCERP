using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOODERP.Models
{
    public class LegacyItem
    {
        public int LegacyItemID { get; set; }
        //[Index("IX_ClientCompanyLegacyItemCode", 1, IsUnique = true)]
        public int ClientCompanyID { get; set; }
        public virtual ClientCompany ClientCompany { get; set; }
        //[Column(TypeName="VARCHAR")]
        [StringLength(40)]
        //[Index("IX_ClientCompanyLegacyItemCode", 2, IsUnique = true)]
        public string LegacyItemCode { get; set; }    
        //[Required]
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }

    }
}
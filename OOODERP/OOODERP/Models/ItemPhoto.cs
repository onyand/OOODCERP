namespace OOODERP.Models
{
    public class ItemPhoto
    {
        //[Index("IX_ItemPhoto", 1, IsUnique = true)]
        public int ItemPhotoID { get; set; }
        //[Index("IX_ItemPhoto", 2, IsUnique = true)]
        public int ItemID { get; set; }
        //[Index("IX_ItemPhoto", 3, IsUnique = true)]
        public virtual Item Item { get; set; }
        //[Index("IX_ItemPhoto", 4, IsUnique = true)]
        public int SaleItemID { get; set; }
        public virtual SaleItem SaleItem { get; set; }
        public byte Photo { get; set; }
    }
}
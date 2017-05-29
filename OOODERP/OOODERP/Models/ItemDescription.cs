namespace OOODERP.Models
{
    public class ItemDescription
    {
        public int ItemDescriptionID { get; set; }
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public int LanguageID { get; set; }
        public virtual Language Language { get; set; }
        public string ItemFullDescription { get; set; }

    }
}
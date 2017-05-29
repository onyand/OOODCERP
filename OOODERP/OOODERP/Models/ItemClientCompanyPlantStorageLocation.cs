using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOODERP.Models
{
    public class ItemClientCompanyPlantStorageLocation
    {
        public int ItemClientCompanyPlantStorageLocationID { get; set; }
        //[Index("IX_ItemPlantStorageBin", 1, IsUnique = true)]
        public int ItemClientCompanyPlantID { get; set; }
        public virtual ItemClientCompanyPlant ItemClientCompanyPlant { get; set; }
        //[Index("IX_ItemPlantStorageBin", 2, IsUnique = true)]
        //[Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public string StorageLocationName { get; set; }
        public string StorageLocationDescription { get; set; }
        //[Index("IX_ItemPlantStorageBin", 3, IsUnique = true)]
        //[Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public string StorageBinName { get; set; }
        public string StorageBinDescription { get; set; }
        public List<ItemClientCompanyPlantStorageLocationCurrentStock> ItemClientCompanyPlantStorageLocationCurrentStocks { get; set; }
        public List<UserItemClientCompanyPlantStorageLocation> UserItemClientCompanyPlantStorageLocations { get; set; }

    }
}
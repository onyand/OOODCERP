using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int PersonnelID { get; set; }
        public virtual Personnel Personnel  { get; set; }
        [StringLength(100)]
        //[Index(IsUnique = true)]
        public string UserName { get; set; }
        public List<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public string PasswordString { get; set; }
        public List<UserDeviceAssignment> UserDeviceAssignments { get; set; }
        public List<UserItemClientCompanyPlantStorageLocation> UserItemClientCompanyPlantStorageLocations { get; set; }

    }
}
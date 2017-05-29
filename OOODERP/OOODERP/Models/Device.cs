using System.Collections.Generic;

namespace OOODERP.Models
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string DeviceMake { get; set; }
        public string DeviceModel { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Identifier1 { get; set; }
        public string Indentfier2 { get; set; }
        public List<UserDeviceAssignment> UserDeviceAssignments { get; set; }

    }
}
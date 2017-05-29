namespace OOODERP.Models
{
    public class UserDeviceAssignment
    {
        public int UserDeviceAssignmentID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int DeviceID { get; set; }
        public virtual Device Device { get; set; }

    }
}
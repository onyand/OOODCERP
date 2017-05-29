using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class JobRole
    {
        public int JobRoleID { get; set; }
        [Required]
        public string JobRoleName { get; set; }
        public string JobDescription { get; set; }
        public List<Personnel> Personnels { get; set; }
    }
}
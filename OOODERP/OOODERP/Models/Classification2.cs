using System.Collections.Generic;

namespace OOODERP.Models
{
    public class Classification2
    {
        public int Classification2ID { get; set; }
        public string ClassificationName { get; set; }
        public string ClassificationDescription { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
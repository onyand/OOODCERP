using System.Collections.Generic;

namespace OOODERP.Models
{
    public class Classification1
    {
        public int Classification1ID { get; set; }
        public string ClassificationName { get; set; }
        public string ClassificationDescription { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
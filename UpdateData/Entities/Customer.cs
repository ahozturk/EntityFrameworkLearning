using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateData.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? LastUpdate { get; private set; }

        public Customer()
        {
            LastUpdate = DateTime.Now;
        }
    }
}

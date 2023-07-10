using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalTables.Entities
{
    internal class Address
    {
        [Key, ForeignKey(nameof(Employee))]
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string No { get; set; }
        public Employee Employee { get; set; }
    }
}

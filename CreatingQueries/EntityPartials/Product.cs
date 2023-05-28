using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingQueries
{
    public partial class Product
    {
        public Product() : this("Unnamed")
        {

        }
        public Product(string name)
        {
            Name = name;
        }
    }
}

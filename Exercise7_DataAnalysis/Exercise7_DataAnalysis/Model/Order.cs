using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_DataAnalysis.Model
{
    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public DateTime DateTime { get; set; }
        public int GrossAmount { get; set; }
        public string City { get; set; }
        public int QuantityId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeSAD.Models
{
    public class InvoiceList
    {
        public string InvNo { get; set; }
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}

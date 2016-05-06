using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int IdTicket { get; set; }
        public int IdProduct { get; set; }
        public decimal SubTotal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositoryInvoice
    {
        IEnumerable<Invoice> GetInvoiceList();
        Invoice AddDetailsInvoice(string IdProduct, string Quantity, string IdTicket);
    }
}

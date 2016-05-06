using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositoryTicket
    {
        Ticket AddTicketList(string Date, string Total);
    }
}

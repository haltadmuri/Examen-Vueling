using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceFruit
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceFruit" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceFruit.svc o ServiceFruit.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceFruit : IServiceFruit
    {
        public void DoWork()
        {
        }

        public IEnumerable<Domain.Product> GetArticleList()
        {
            throw new NotImplementedException();
        }

        public Domain.Product GetArticle(string id)
        {
            throw new NotImplementedException();
        }

        public Domain.Product Add(string name, string price)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Invoice> GetDetalleVentaList()
        {
            throw new NotImplementedException();
        }

        public Domain.Invoice AddDetalleVentaList(string IdProduct, string Quantity, string IdTicket)
        {
            throw new NotImplementedException();
        }

        public Domain.Ticket AddVentaList(string Date, string Total)
        {
            throw new NotImplementedException();
        }
    }
}

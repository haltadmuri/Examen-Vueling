    using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceFruit
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceFruit" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceFruit
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetArticleList")]
        IEnumerable<Product> GetProductList();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetArticle/{id}")]
        Product GetArticle(string id);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Article/Add/{name}/{price}")]
        Product Add(string name, string price);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetDetalleVentaList")]
        IEnumerable<Invoice> GetDetalleVentaList();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddDetalleVentaList/{IdArticles}/{Quantity}/{IdSale}")]
        Invoice AddDetalleVentaList(string IdProduct, string Quantity, string IdTicket);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddVentaList/{Date}/{Total}")]
        Ticket AddVentaList(string Date, string Total);
     
    }
}

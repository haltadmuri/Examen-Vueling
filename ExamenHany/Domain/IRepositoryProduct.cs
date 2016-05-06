using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositoryProduct
    {
        IEnumerable<Product> GetProductList();
        Product GetProduct(int id);
        Product Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}

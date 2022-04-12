

using MongoRepo.Manager;
using MongoRepo.Repository;
using NetCore_MongoDB_CRUDOperation.Interfaces.Manager;
using NetCore_MongoDB_CRUDOperation.Models;
using NetCore_MongoDB_CRUDOperation.Repository;

namespace NetCore_MongoDB_CRUDOperation.Manager
{
    public class ProductManager : CommonManager<Product>, IProductManager
    {
        public ProductManager():base(new ProductRepository())
        {
        }
    }
}

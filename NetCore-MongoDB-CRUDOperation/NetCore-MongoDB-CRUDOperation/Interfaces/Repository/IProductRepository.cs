using MongoRepo.Interfaces.Repository;
using NetCore_MongoDB_CRUDOperation.Models;

namespace NetCore_MongoDB_CRUDOperation.Interfaces.Repository
{
    public interface IProductRepository:ICommonRepository<Product>
    {
    }
}

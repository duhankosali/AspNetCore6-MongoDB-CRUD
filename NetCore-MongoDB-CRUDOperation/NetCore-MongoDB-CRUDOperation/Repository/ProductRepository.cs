using MongoRepo.Context;
using MongoRepo.Repository;
using NetCore_MongoDB_CRUDOperation.Interfaces.Repository;
using NetCore_MongoDB_CRUDOperation.Models;
using NetCore_MongoDB_CRUDOperation.Settings;

namespace NetCore_MongoDB_CRUDOperation.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository():base(new ApplicationDbContext(MongoDbConfig.Connection,MongoDbConfig.DbName))
        {
        }
    }
}

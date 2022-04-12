using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace NetCore_MongoDB_CRUDOperation.Models
{
    public class Product
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Display(Name = "Ürün Adı")]
        public string ItemName { get; set; }
        [Display(Name = "Fiyat")]
        public string Price { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}

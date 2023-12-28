using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoRepositoryPattern.Domain.Model.Base
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public int Id { get; set; }
    }
}

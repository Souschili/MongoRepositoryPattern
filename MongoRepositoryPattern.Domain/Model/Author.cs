using MongoDB.Bson.Serialization.Attributes;
using MongoRepositoryPattern.Domain.Custom;
using MongoRepositoryPattern.Domain.Model.Base;

namespace MongoRepositoryPattern.Domain.Model
{
    [CollectionName("author")]
    public class Author:BaseEntity
    {
        [BsonElement("Name")]
        public string FirstName { get; set; }=string.Empty;

        [BsonElement("LastName")]
        public string LastName { get; set; } = string.Empty;
    }
}

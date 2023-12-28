﻿using MongoDB.Bson.Serialization.Attributes;
using MongoRepositoryPattern.Domain.Model.Base;

namespace MongoRepositoryPattern.Domain.Model
{

    public class Author:BaseEntity
    {
        [BsonElement("Name")]
        public string Name { get; set; }=string.Empty;

        [BsonElement("Description")]
        public string Description { get; set; } = string.Empty;
    }
}

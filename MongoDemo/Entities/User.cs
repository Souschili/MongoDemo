﻿using MongoDB.Bson.Serialization.Attributes;

namespace MongoDemo.Entities
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("UserName")]
        public string Name { get; set; } = string.Empty;
        [BsonElement("UserAge")]
        public int Age { get; set; }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportPMD1
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public int Ocena { get; set; }
        public int Discount { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public MongoDBRef Category { get; set; }
        //public Category Category { get; set; }
    }
}

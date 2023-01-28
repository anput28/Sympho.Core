using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization;
using Sympho.Core.Api.Mapping.Conventions;

namespace Sympho.Core.Api.Mapping {
    public static class MongoDbMapping {

        public static void AddConfigurations() {
            /*
             * This allows you to automatically generate a value for Id field of entities.
             * In particular, it allows you to have a string Id field that will be transformed 
             * into an ObjectId type on MongoDb and vice versa.
             */
            BsonSerializer.RegisterIdGenerator(typeof(string), StringObjectIdGenerator.Instance);


            // Register all MongoDB conventions for entity mapping
            RegisterConventions.RegisterAll();

        }
    }
}

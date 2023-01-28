using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using Sympho.Core.Domain.Entities;

namespace Sympho.Core.Api.Mapping {
    public static class FilterMapping {

        public static void Register() {
            BsonClassMap.RegisterClassMap<Filter>(cm => {
                cm.AutoMap();
                cm.MapIdMember(f => f.Id).SetIdGenerator(StringObjectIdGenerator.Instance);
                cm.IdMemberMap.SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }

    }
}

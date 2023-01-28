using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;

namespace Sympho.Core.Api.Mapping.Conventions {
    public class LowerCaseElementNameConvention : IMemberMapConvention {
        public string Name => "LowerCaseElementName";

        public void Apply(BsonMemberMap memberMap) {
            memberMap.SetElementName(memberMap.ElementName.ToLower());
        }

    }
}

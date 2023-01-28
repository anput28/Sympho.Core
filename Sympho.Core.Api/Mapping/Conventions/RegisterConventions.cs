using MongoDB.Bson.Serialization.Conventions;

namespace Sympho.Core.Api.Mapping.Conventions {
    public static class RegisterConventions {

        public static void RegisterAll() {
            var pack = new ConventionPack {
                new LowerCaseElementNameConvention()
            };

            ConventionRegistry.Register(nameof(LowerCaseElementNameConvention), pack, t => true);
        }

    }
}

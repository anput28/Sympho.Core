using MongoDB.Bson.Serialization;
using Sympho.Core.Domain.Entities;

namespace Sympho.Core.Api.Mapping {
    public static class RegisterEntityMapping {

        public static void RegisterAll() {
            FilterMapping.Register();
        }

    }
}

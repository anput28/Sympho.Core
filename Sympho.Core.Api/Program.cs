using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using Sympho.Core.Api.Mapping;
using Sympho.Core.Api.Mapping.Conventions;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    MongoDbMapping.AddConfigurations();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment()) {
        // Add development Middleware
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}

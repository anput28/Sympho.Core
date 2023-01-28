using Sympho.Core.Api.Mapping;
using Sympho.Core.Api.Mapping.Conventions;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
}

// Register all MongoDB conventions for entity mapping
RegisterConventions.RegisterAll();

// Register all class maps for mapping between MongoDB document and entities
RegisterEntityMapping.RegisterAll();

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

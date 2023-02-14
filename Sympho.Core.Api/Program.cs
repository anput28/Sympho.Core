using Sympho.Core.Api.Mapping;
using Sympho.Core.Domain.Options;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.Configure<MongoDBSettings>(
        builder.Configuration.GetSection("MongoDBSettings"));
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

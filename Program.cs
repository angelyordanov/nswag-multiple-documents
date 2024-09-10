using NswagMultipleDocuments;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();

services.AddEndpointsApiExplorer();

services.AddOpenApiDocument((document, _) =>
{
    document.Title = "Public";
    document.DocumentName = "public";
    document.OperationProcessors.Insert(
        0,
        new ControllerTypeFilteringOperationProcessor(
            t => t.Name.StartsWith("Public")));
});

services.AddOpenApiDocument((document, _) =>
{
    document.Title = "Internal";
    document.DocumentName = "internal";
    document.OperationProcessors.Insert(
        0,
        new ControllerTypeFilteringOperationProcessor(
            t => t.Name.StartsWith("Internal")));
});

var app = builder.Build();

app.UseOpenApi(settings =>
{
    settings.DocumentName = "public";
});

app.UseOpenApi(settings =>
{
    settings.DocumentName = "internal";
});

app.UseSwaggerUi();

app.MapControllers();

app.Run();

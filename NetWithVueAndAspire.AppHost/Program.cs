
using Projects;

var builder = DistributedApplication.CreateBuilder(args);
var api = builder.AddProject<NetWithVueAndAspire_Api>("Api");

var web = builder.AddNpmApp("vue", "../NetWithVueAndAspire.Web","dev")
    .WithNpmPackageInstallation()
    .WithReference(api)
    .WaitFor(api)
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();
builder.Build().Run();

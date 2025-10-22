
using Projects;

var builder = DistributedApplication.CreateBuilder(args);
var api = builder.AddProject<NetWithVueAndAspire_Api>("Api");
builder.Build().Run();

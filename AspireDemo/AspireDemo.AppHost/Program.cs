var builder = DistributedApplication.CreateBuilder(args);
var api = builder.AddProject<Projects.AspireDemo_Api>("api");
builder.AddProject<Projects.AspireDemo_Web>("frontend").WithReference(api);
builder.Build().Run();
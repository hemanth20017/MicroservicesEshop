var builder = WebApplication.CreateBuilder(args);
//Add containers here
var app = builder.Build();
//Configure Http req pipeline
app.Run();

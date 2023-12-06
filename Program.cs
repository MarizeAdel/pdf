var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
defaultFilesOptions.DefaultFileNames.Clear();
defaultFilesOptions.DefaultFileNames.Add("defult.html");
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapGet("/", () => $"hosting env {builder.Environment.EnvironmentName}");

app.Run();

using PetCarePro.Components;
using Microsoft.EntityFrameworkCore;
using PetCarePro.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=petcarepro.db"));

var app = builder.Build();

var databasePath = Path.Combine(app.Environment.ContentRootPath, "petcarepro.db");

if (!File.Exists(databasePath))
{
    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        var sqlPath = Path.Combine(app.Environment.ContentRootPath, "Data", "init.sql");
        var sql = File.ReadAllText(sqlPath);

        db.Database.OpenConnection();

        using var command = db.Database.GetDbConnection().CreateCommand();
        command.CommandText = sql;
        command.ExecuteNonQuery();

        db.Database.CloseConnection();
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
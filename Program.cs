using PetCarePro.Components;
using Microsoft.EntityFrameworkCore;
using PetCarePro.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Database toevoegen
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=petcarepro.db"));

var app = builder.Build();

// Database initialiseren vanuit init.sql
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

// Configure the HTTP request pipeline.
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
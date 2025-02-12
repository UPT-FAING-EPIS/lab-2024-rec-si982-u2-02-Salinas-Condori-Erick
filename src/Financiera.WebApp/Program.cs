using Financiera.WebApp;
using Microsoft.EntityFrameworkCore;
using Financiera.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Aquí agregamos la conexión a la base de datos
string connectionString = builder.Configuration.GetConnectionString("FinancieraBD") ?? "";
builder.Services.AddDbContext<FinancieraContexto>(
    opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// Si tienes el paquete QuickGrid, también se agrega el adaptador para Entity Framework
builder.Services.AddQuickGridEntityFrameworkAdapter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

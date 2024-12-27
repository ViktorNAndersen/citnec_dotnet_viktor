using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesPlayground.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<RazorPagesPostContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesPostContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesPostContext' not found.")));



if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<RazorPagesPostContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesPostContext")));
}
else
{
    builder.Services.AddDbContext<RazorPagesPostContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionPostContext")));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapGet("/", () => Results.Redirect("/Posts"));
app.MapRazorPages();

app.Run();
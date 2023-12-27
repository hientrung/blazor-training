using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ServerApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//add service
builder.Services.AddSingleton<CountService>();
builder .Services.AddScoped<ScopedCountService>();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

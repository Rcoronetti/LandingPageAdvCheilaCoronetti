using CheilaCoronetti.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// SSR puro: sem SignalR, sem interatividade
builder.Services.AddRazorComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>();

app.Run();
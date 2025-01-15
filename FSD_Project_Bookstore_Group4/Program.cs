using FSD_Project_Bookstore_Group4.Components;
using FSD_Project_Bookstore_Group4.Components.Account;
using FSD_Project_Bookstore_Group4.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
// test
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<FSD_Project_Bookstore_Group4Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FSD_Project_Bookstore_Group4Context") ?? throw new InvalidOperationException("Connection string 'FSD_Project_Bookstore_Group4Context' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var connectionString = builder.Configuration.GetConnectionString("FSD_Project_Bookstore_Group4Context") ?? throw new InvalidOperationException("Connection string 'FSD_Project_Bookstore_Group4Context' not found.");;

builder.Services.AddDbContext<FSD_Project_Bookstore_Group4Context>(options => options.UseSqlServer(connectionString));

// Add services to the container. 
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityUserAccessor>();

builder.Services.AddScoped<IdentityRedirectManager>();

builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

builder.Services.AddIdentityCore<FSD_Project_Bookstore_Group4User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<FSD_Project_Bookstore_Group4Context>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<FSD_Project_Bookstore_Group4User>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();;

app.Run();

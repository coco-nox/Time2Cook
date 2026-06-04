using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opts =>
    {
        opts.LoginPath = "/Login";
        opts.AccessDeniedPath = "/Login";
        opts.Cookie.Name = "T2CAuth";
        opts.ExpireTimeSpan = TimeSpan.FromDays(7);
        opts.SlidingExpiration = true;
    });

builder.Services.AddSession(opts =>
{
    opts.IdleTimeout = TimeSpan.FromHours(4);
    opts.Cookie.HttpOnly = true;
    opts.Cookie.IsEssential = true;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();

app.Run();

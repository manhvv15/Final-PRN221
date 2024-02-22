using Final_PRN221.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Final_PRN221.Models;

namespace Final_PRN221
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                string connectionString = builder.Configuration.GetConnectionString("MyDB")!;
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddAuthentication()
    .AddGoogle(googleOptions =>
    {
        // ??c thông tin Authentication:Google t? appsettings.json
        IConfigurationSection googleAuthNSection = builder.Configuration.GetSection("Authentication:Google");

        // Thi?t l?p ClientID và ClientSecret ?? truy c?p API google
        googleOptions.ClientId = googleAuthNSection["ClientId"];
        googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
        // C?u hình Url callback l?i t? Google (không thi?t l?p thì m?c ??nh là /signin-google)
        googleOptions.CallbackPath = "/login-with-google";
    })              // thêm provider Google và c?u hình
    .AddFacebook(facebookOptions =>
    {
        // ??c c?u hìnhbuilder.
        IConfigurationSection facebookAuthNSection = builder.Configuration.GetSection("Authentication:Facebook");
        facebookOptions.AppId = facebookAuthNSection["AppId"];
        facebookOptions.AppSecret = facebookAuthNSection["AppSecret"];
        // Thi?t l?p ???ng d?n Facebook chuy?n h??ng ??n
        facebookOptions.CallbackPath = "/login-with-facebook";
    });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication(); ;

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
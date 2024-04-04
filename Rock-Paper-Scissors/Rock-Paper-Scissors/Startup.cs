using Microsoft.AspNetCore.Builder;

namespace Rock_Paper_Scissors
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add MVC services to the service container
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Use routing
            app.UseRouting();

            // Add endpoint routing middleware to the request pipeline
            app.UseEndpoints(endpoints =>
            {
                // Map controller routes
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

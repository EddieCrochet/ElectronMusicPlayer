using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ElectronMusicPlayer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(routes =>
            {
                //this maps the app to use MVC routing
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{Id?}");
            });

            Bootstrap();
        }

        //This method opens an electron window for us upon startup
        public async void Bootstrap()
        {
            var options = new BrowserWindowOptions
            {
<<<<<<< HEAD
=======
                await context.Response.WriteAsync("Hello World!");
            });

            Bootstrap();
        }

        public async void Bootstrap()
        {
            var options = new BrowserWindowOptions
            {
>>>>>>> 743ce4548a1135ed2dff4daecb79f20aaa30a1a5
                WebPreferences = new WebPreferences
                {
                    WebSecurity = false
                }
            };
<<<<<<< HEAD

=======
>>>>>>> 743ce4548a1135ed2dff4daecb79f20aaa30a1a5
            await Electron.WindowManager.CreateWindowAsync(options);
        }
    }
}

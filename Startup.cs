using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVCApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este método é usado para configurar os serviços da aplicação.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // Adiciona suporte para controladores e visualizações

            // Outros serviços podem ser adicionados aqui, como serviços de banco de dados, autenticação, etc.
        }

        // Este método é usado para configurar a pipeline de middleware da aplicação.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Página de erro detalhada em ambiente de desenvolvimento
            }
            else
            {
                app.UseExceptionHandler("/Error"); // Página de erro genérica em ambiente de produção
            }

            app.UseStaticFiles(); // Permite que a aplicação sirva arquivos estáticos, como CSS e JavaScript

            app.UseRouting(); // Configuração de roteamento

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); // Rota padrão para os controladores MVC
            });
        }
    }
}

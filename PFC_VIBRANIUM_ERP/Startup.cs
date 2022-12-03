using PFC_VIBRANIUM_ERP.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PFC_VIBRANIUM_ERP.Repositorio;
using Microsoft.AspNetCore.Http;

namespace PFC_VIBRANIUM_ERP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddControllersWithViews();

            services.AddEntityFrameworkNpgsql().AddDbContext<BancoContext>(o => o.UseNpgsql(Configuration.GetConnectionString("DataBase")));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IAcessoRepositorio, AcessoRepositorio>();

            //services.AddScoped<IAcessoRepositorio, AcessoRepositorio>();

            /*services.AddScoped<ICAPRepositorio, CAPRepositorio>();
            services.AddScoped<ICARRepositorio, CARRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IEstoqueRepositorio, EstoqueRepositorio>();
            services.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();
            services.AddScoped<IFuncionarioRepositorio, FuncionarioRepositorio>();
            services.AddScoped<IOPRepositorio, OPRepositorio>();
            services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();*/

            services.AddSession(o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

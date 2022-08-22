using LibraryPOC.Context;
using LibraryPOC.Controllers;
using LibraryPOC.Model;
using LibraryPOC.Model.AuthorManager;
using LibraryPOC.Model.BookManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace LibraryPOC
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
            services.AddControllers();
            services.AddDbContext<DataContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("LibDB")));
           // services.AddDbContext<BookContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("LibDB")));
            services.AddScoped<IDataRepository<Book>, BookManager>();
            services.AddScoped<IDataRepository<Author>, AuthorManager>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Library Application", Version = "v1" });
            });
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Library Application v1"));
            }



            app.UseHttpsRedirection();



            app.UseRouting();
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));//--------------



            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
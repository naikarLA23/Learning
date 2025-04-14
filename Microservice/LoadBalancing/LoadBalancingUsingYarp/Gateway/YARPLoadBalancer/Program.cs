
namespace YARPLoadBalancer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddReverseProxy()  //Add the required services for YARP
                   .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy")); //load the reverse proxy configuration from application settings

            builder.Services.AddHealthChecks();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapReverseProxy(); // Introduce the reverse proxy middleware
            app.MapHealthChecks("health");

            app.Run();
        }
    }
}

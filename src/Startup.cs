using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace HcBug
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services) => services
      .AddGraphQLServer()
      .AddQueryType<Query>();

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) => app
      .UseRouting()
      .UseEndpoints(endpoints => endpoints.MapGraphQL());
  }
}

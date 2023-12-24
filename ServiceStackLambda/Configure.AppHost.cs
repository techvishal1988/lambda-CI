using Funq;
using ServiceStack;
using ServiceStackLambda.ServiceInterface;

[assembly: HostingStartup(typeof(ServiceStackLambda.AppHost))]

namespace ServiceStackLambda;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("ServiceStackLambda", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(new HostConfig {
        });
    }
}

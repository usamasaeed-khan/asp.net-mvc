using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesStore.Startup))]
namespace MoviesStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

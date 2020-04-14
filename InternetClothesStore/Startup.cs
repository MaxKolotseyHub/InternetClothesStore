using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternetClothesStore.Startup))]
namespace InternetClothesStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

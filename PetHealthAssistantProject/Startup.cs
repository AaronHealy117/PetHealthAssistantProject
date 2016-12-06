using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetHealthAssistantProject.Startup))]
namespace PetHealthAssistantProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

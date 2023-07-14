//using RainflyAdventures.Training.Feature.PageContent.Factories;
//using RainflyAdventures.Training.Feature.PageContent.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace RainflyAdventures.Training.Feature.PageContent.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<IHeroService, HeroService>();
            //serviceCollection.AddTransient<IHeroViewModelFactory, HeroViewModelFactory>();
        }
    }
}

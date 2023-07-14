//using RainflyAdventures.Training.Feature.Event.Factories;
//using RainflyAdventures.Training.Feature.Event.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace RainflyAdventures.Training.Feature.Event.DI
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

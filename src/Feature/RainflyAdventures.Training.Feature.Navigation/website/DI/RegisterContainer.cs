//using RainflyAdventures.Training.Feature.Navigation.Factories;
//using RainflyAdventures.Training.Feature.Navigation.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace RainflyAdventures.Training.Feature.Navigation.DI
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

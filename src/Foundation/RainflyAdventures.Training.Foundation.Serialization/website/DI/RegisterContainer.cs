//using RainflyAdventures.Training.Foundation.Serialization.Factories;
//using RainflyAdventures.Training.Foundation.Serialization.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace RainflyAdventures.Training.Foundation.Serialization.DI
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

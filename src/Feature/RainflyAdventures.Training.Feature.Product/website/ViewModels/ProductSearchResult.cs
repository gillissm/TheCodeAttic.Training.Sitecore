using RainflyAdventures.Training.Foundation.Core.Models;
using Sitecore.ContentSearch;

namespace RainflyAdventures.Training.Feature.Product.ViewModels
{
    public class ProductSearchResult : CoreResultItem
    {
        [IndexField("Cost")]
        public string Cost { get; set; }

        [IndexField("Rating")]
        public string Rating { get; set; }

    }
}

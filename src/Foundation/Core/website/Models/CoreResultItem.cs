using RainflyAdventures.Training.Foundation.Search.Models;
using Sitecore.ContentSearch;

namespace RainflyAdventures.Training.Foundation.Core.Models
{
    public class CoreResultItem : BaseResultItem
    {
        [IndexField("Copy")]
        public string Copy { get; set; }

        [IndexField("Title")]
        public string Title { get; set; }
    }
}

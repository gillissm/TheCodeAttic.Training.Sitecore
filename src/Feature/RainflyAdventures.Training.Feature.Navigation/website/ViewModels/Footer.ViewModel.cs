using Sitecore.Data.Items;
using System.Collections.Generic;

namespace RainflyAdventures.Training.Feature.Navigation.Models
{
    public class FooterViewModel
    {
        public Item SCItem { get; set; }
        public List<LinkViewModel> Links { get; set; }
        public string CSSClass { get; set; }

        public FooterViewModel()
        {
            Links = new List<LinkViewModel>();
        }
    }
}
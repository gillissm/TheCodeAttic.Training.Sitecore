using Sitecore.Data.Items;
using System.Collections.Generic;

namespace RainflyAdventures.Training.Feature.Navigation.Models
{
    public class HeaderViewModel
    {
        public Item SCItem { get; set; }
        public List<NavLinkViewModel> NavLinks { get; set; }

        public HeaderViewModel()
        {
            NavLinks = new List<NavLinkViewModel>();
        }
    }
}
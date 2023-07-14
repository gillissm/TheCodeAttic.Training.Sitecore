using Sitecore.Data.Items;
using System.Collections.Generic;

namespace RainflyAdventures.Training.Feature.Navigation.Models
{
    public class NavLinkViewModel
	{
		public Item SCItem { get; set; }
		public List<NavLinkViewModel> ChildLinks { get; set; }

		public string DisplayName
		{
			get
			{
				return SCItem.Fields[ModelConstants.NavigationLinkConstants.DisplayTitleFieldID].Value;
			}
		}

		public NavLinkViewModel() { }
		public NavLinkViewModel(Item sCItem)
		{
			SCItem = sCItem;
			ChildLinks = new List<NavLinkViewModel>();
			foreach(Item child in sCItem.Children)
			{
				ChildLinks.Add(new NavLinkViewModel(child));
			}
		}
	}
}
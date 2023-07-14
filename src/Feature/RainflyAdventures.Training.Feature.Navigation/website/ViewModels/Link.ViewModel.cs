using Sitecore.Data.Items;

namespace RainflyAdventures.Training.Feature.Navigation.Models
{
    public class LinkViewModel
	{
		public string Url { get; set; }
		public string Displayname { get; set; }

		public LinkViewModel() { }

		public LinkViewModel(Item scItem)
		{
			Sitecore.Data.Fields.LinkField linkfield = scItem.Fields[ModelConstants.NavigationLinkConstants.GoToLinkFieldID];

			Url = linkfield.Url;
			Displayname = scItem.Fields[ModelConstants.NavigationLinkConstants.DisplayTitleFieldID].Value;
		}
	}
}
using Sitecore.Data.Fields;
using Sitecore.Data;
using System.Collections.Generic;

namespace RainflyAdventures.Training.Feature.PageContent.ViewModels
{
    public class FieldSampleViewModel
    {
        public string SingleLineText { get; set; }

        public string RichText { get; set; }
        public string RichTextFull { get; set; }

        public string GeneralLink { get; set; }
        public string GeneralLinkFull { get; set; }
        public LinkField GeneralLinkFld { get; set; }

        public string MultiList { get; set; }
        public List<CardModel> Picks { get; set; }

        public string ImageUrl { get; set; }
    }

    public class CardModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ID ItemId { get; set; }
    }
}

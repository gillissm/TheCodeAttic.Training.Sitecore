using Sitecore;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Links;
using System;

namespace RainflyAdventures.Training.Foundation.Search.ComputedFields
{
    public class PageUrlField : IComputedIndexField
    {
        public string FieldName { get; set; }
        public string ReturnType { get; set; }

        public object ComputeFieldValue(IIndexable indexable)
        {
            var item = (Item)(indexable as SitecoreIndexableItem);
            Assert.ArgumentNotNull(item, "item");

            //check if this item has layout
            if (!ShouldIndexItem(item))
                return null;

            var urlOptions2 = LinkManager.GetDefaultUrlOptions();
            urlOptions2.AlwaysIncludeServerUrl = true;
            urlOptions2.SiteResolving = true;
            urlOptions2.LanguageEmbedding = LanguageEmbedding.Never;
            urlOptions2.LowercaseUrls = true;
            string url2 = LinkManager.GetItemUrl(item, urlOptions2);

            // add missing protocal if not there- this should be set in the siteDefinition.config using the "scheme" property  
            if (url2.StartsWith(":"))
            {
                url2 = String.Format("{0}{1}", "http", url2);
            }
            return url2;
        }

        protected virtual bool ShouldIndexItem(Item item)
        {
            //only items w/ layout that are not template standard values
            return item.Visualization != null && item.Visualization.Layout != null && !item.Paths.LongID.Contains(ItemIDs.TemplateRoot.ToString());
        }
    }
}

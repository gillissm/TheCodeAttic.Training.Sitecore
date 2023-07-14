using Sitecore.ContentSearch.ComputedFields;
using Sitecore.ContentSearch;
using Sitecore.Data.Managers;
using System.Collections.Generic;
using System.Linq;
using Sitecore.Data.Items;

namespace RainflyAdventures.Training.Foundation.Search.ComputedFields
{
    public class TemplateInheritance : AbstractComputedIndexField
    {
        public override object ComputeFieldValue(IIndexable indexable)
        {
            Item item = indexable as SitecoreIndexableItem;

            if (item == null) { return null; }

            List<string> templateIds = new List<string>();

            var t = TemplateManager.GetTemplate(item);
            templateIds = t.GetBaseTemplates().Select(a => a.ID.ToString()).ToList();

            if (templateIds.Any())
                return templateIds;

            return null;
        }
    }
}

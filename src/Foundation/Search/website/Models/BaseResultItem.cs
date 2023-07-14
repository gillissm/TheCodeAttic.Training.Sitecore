using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RainflyAdventures.Training.Foundation.Search.Models
{
    public class BaseResultItem : SearchResultItem
    {
        [IndexField("_templates")]
        public string TemplateListAsString { get; set; }

        public List<string> TemplateList
        {
            get
            {
                if (!string.IsNullOrEmpty(TemplateListAsString))
                    return TemplateListAsString.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                return null;
            }

        }

        [IndexField("pageurl")]
        public string PageUrl { get; set; }
    }
}

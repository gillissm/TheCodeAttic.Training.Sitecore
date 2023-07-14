using RainflyAdventures.Training.Feature.Product.ViewModels;
using Sitecore.ContentSearch;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RainflyAdventures.Training.Feature.Product.Controllers
{
    public class TheShopController : Controller
    {
        public ActionResult BuildProductList()
        {
            var searchIndexName = $"sitecore_{Sitecore.Context.Database.Name}_index";
            var myIndex = ContentSearchManager.GetIndex(searchIndexName);
            List<ProductSearchResult> searchResults = new List<ProductSearchResult>();
            using (var context = myIndex.CreateSearchContext())
            {
                searchResults = context.GetQueryable<ProductSearchResult>()
                 .Where(x => x.TemplateListAsString.Contains(ModelConstants.ProductConstants.TemplateIdString)
                   && x.Path.Contains(Sitecore.Context.Site.RootPath.ToLowerInvariant())).ToList();
            }

            return View("/Views/Products/ProductList.cshtml", searchResults);
        }
    }
}

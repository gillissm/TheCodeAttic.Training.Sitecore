using RainflyAdventures.Training.Feature.Navigation.Models;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace RainflyAdventures.Training.Feature.Navigation.Controllers
{
    public class HeaderController : Controller
    {
        public ActionResult GetHeader()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var headerVM = new HeaderViewModel();

            if (dataSourceId != null)
            {
                var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
                if (dataSource != null)
                {
                    headerVM.SCItem = dataSource;
                    var navItems = dataSource.Children;
                    foreach (Item i in navItems)
                    {
                        headerVM.NavLinks.Add(new NavLinkViewModel(i));
                    }
                }
            }
            return View("/Views/Header/Header.cshtml", headerVM);
        }
    }
}

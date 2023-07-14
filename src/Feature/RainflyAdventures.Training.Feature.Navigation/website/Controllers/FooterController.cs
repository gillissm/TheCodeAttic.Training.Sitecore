using RainflyAdventures.Training.Feature.Navigation.Models;
using Sitecore.Data.Items;
using System.Web.Mvc;

namespace RainflyAdventures.Training.Feature.Navigation.Controllers
{
    public class FooterController : Controller
    {
        public ActionResult GetFooter()
        {

            var footerData = Sitecore.Context.Item.Axes.SelectSingleItem("./ancestor-or-self::*[@@templatename='Site']/Data/GlobalFooter");
            var footerVM = new FooterViewModel();
            if (footerData != null)
            {

                footerVM.SCItem = footerData;
                var navItems = footerData.Children;
                foreach (Item i in navItems)
                {
                    footerVM.Links.Add(new LinkViewModel(i));
                }

            }
            return View("/Views/Footer/Footer.cshtml", footerVM);
        }
    }
}

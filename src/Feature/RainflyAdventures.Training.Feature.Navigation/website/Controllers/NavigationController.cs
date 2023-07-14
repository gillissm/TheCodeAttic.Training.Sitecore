using Sitecore.Mvc.Controllers;
using System.Web.Mvc;


namespace RainflyAdventures.Training.Feature.Navigation.Controllers
{
    public class NavigationController : SitecoreController
    {
       
        public NavigationController()
        {
            
        }

        public ActionResult Navigation()
        {
            

            return View();
        }
    }
}

using Sitecore.Mvc.Controllers;
using System.Web.Mvc;


namespace RainflyAdventures.Training.Feature.PageContent.Controllers
{
    public class PageContentController : SitecoreController
    {
       
        public PageContentController()
        {
            
        }

        public ActionResult PageContent()
        {
            

            return View();
        }
    }
}

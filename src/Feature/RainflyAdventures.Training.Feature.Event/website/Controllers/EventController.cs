using Sitecore.Mvc.Controllers;
using System.Web.Mvc;


namespace RainflyAdventures.Training.Feature.Event.Controllers
{
    public class EventController : SitecoreController
    {
       
        public EventController()
        {
            
        }

        public ActionResult Event()
        {
            

            return View();
        }
    }
}

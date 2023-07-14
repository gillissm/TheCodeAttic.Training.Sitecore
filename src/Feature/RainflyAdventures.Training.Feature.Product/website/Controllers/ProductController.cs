using Sitecore.Mvc.Controllers;
using System.Web.Mvc;


namespace RainflyAdventures.Training.Feature.Product.Controllers
{
    public class ProductController : SitecoreController
    {
       
        public ProductController()
        {
            
        }

        public ActionResult Product()
        {
            

            return View();
        }
    }
}

using System;
using System.Web.Mvc;


namespace RainflyAdventures.Training.Feature.Product.Controllers
{
    public class QuickViewController : Controller
    {
        // GET: QuickView
        [HttpPost]
        public JsonResult GetQuickView(string id)
        {
            JsonResult jResult = new JsonResult();
            jResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            if (string.IsNullOrWhiteSpace(id))
            {
                jResult.Data = new { copy = "Product cannot be found." };
                return jResult;
            }

            var pItem = Sitecore.Context.Database.GetItem(id);
            if (pItem == null)
            {
                jResult.Data = new { copy = "Product cannot be found." };
                return jResult;
            }

            Sitecore.Data.Fields.ImageField imageField = pItem.Fields[ModelConstants.ProductConstants.ImageFieldId];

            //https://doc.sitecore.com/xp/en/developers/92/sitecore-experience-manager/access-image-fields.htm
            if (imageField != null && imageField.MediaItem != null)
            {
                Sitecore.Data.Items.MediaItem image = new Sitecore.Data.Items.MediaItem(imageField.MediaItem);

                string src = Sitecore.StringUtil.EnsurePrefix('/', Sitecore.Resources.Media.MediaManager.GetMediaUrl(image));

                string imgTag = String.Format(@"<img src=""{0}"" alt=""{1}"" />", src, image.Alt);
                jResult.Data = new
                {
                    copy = pItem.Fields[ModelConstants.ProductConstants.TitleFieldId].Value,
                    imgUrl = src,
                    imgHtml = imgTag
                };
            }

            return jResult;
        }
    }
}

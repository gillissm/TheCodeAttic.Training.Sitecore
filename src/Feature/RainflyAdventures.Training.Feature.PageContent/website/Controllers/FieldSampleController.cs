using RainflyAdventures.Training.Feature.PageContent.ViewModels;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web.Mvc;


namespace RainflyAdventures.Training.Feature.PageContent.Controllers
{

    public class FieldSampleController : Controller
    {
        public ActionResult FieldControlSample()
        {
            //Create the view model
            FieldSampleViewModel vm = new FieldSampleViewModel();

            //Get the current context
            Item dataItem = RenderingContext.CurrentOrNull?.Rendering.Item;

            #region Rendering Fields - Strings

            vm.SingleLineText = dataItem.Fields["Single-Line-Text"].Value;
            vm.RichText = dataItem.Fields["Rich-Text"].Value;
            vm.RichTextFull = FieldRenderer.Render(dataItem, "Rich-Text");

            #endregion

            return View("/Views/FieldSample/FieldControlSample.cshtml", vm);

            #region Rendering Field - Link Field

            vm.GeneralLink = dataItem.Fields["General-Link"].Value;
            vm.GeneralLinkFull = FieldRenderer.Render(dataItem, "General-Link");
            Sitecore.Data.Fields.LinkField lf = dataItem.Fields["General-Link"];
            vm.GeneralLinkFld = lf;

            #endregion


            #region Rendering Field - Multi-List
            vm.Picks = new List<CardModel>();

            vm.MultiList = dataItem.Fields["Multi-List"].Value;
            //Read the Multifield List
            Sitecore.Data.Fields.MultilistField multiselectField = dataItem.Fields["Multi-List"];

            Sitecore.Data.Items.Item[] items = multiselectField.GetItems();

            foreach (var item in items)
            {
                CardModel plm = new CardModel();
                plm.Name = FieldRenderer.Render(item, "Title");
                plm.Description = FieldRenderer.Render(item, "Copy");
                plm.ItemId = item.ID;
                vm.Picks.Add(plm);
            }
            #endregion

            #region Media Item

            ImageField imgFld = dataItem.Fields["Img"];

            //Always null check
            if (imgFld != null && imgFld.MediaItem != null)
            {
                //Get media item
                MediaItem mediaItem = new MediaItem(imgFld.MediaItem);

                //Get media url
                string mediaUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(mediaItem);

                vm.ImageUrl = mediaUrl;
            }

            #endregion


        }

    }
}

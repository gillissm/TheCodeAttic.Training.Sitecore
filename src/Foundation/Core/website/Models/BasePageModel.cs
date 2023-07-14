using Sitecore.Mvc.Presentation;


namespace RainflyAdventures.Training.Foundation.Core.Models
{
    public class BasePageModel:IRenderingModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKeywords { get; set; }
        public string BrowserTitle { get; set; }
        public string BodyCssClass { get; set; }

        public void Initialize(Rendering rendering)
        {
            this.Title = rendering.Item.Fields[ModelConstants.TitleConstants.TitleFieldID].Value;
            this.Content = rendering.Item.Fields[ModelConstants.ContentConstants.ContentFieldID].Value;
            this.Image = rendering.Item.Fields[ModelConstants.ImageConstants.ImageFieldID].Value;
            this.MetaDesc = rendering.Item.Fields[ModelConstants.PageMetadataConstants.MetaDescFieldID].Value;
            this.MetaKeywords = rendering.Item.Fields[ModelConstants.PageMetadataConstants.MetaKeywordsFieldID].Value;
            this.BrowserTitle = rendering.Item.Fields[ModelConstants.PageMetadataConstants.BrowserTitleFieldID].Value;
            this.BodyCssClass = rendering.Item.Fields[ModelConstants.StyleableConstants.BodyCSSFieldID].Value;
        }
    }
}

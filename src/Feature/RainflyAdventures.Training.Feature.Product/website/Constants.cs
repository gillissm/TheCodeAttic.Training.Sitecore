using Sitecore.Data;
using System;
using static RainflyAdventures.Training.Foundation.Core.ModelConstants;

namespace RainflyAdventures.Training.Feature.Product
{
    public static class ModelConstants
    {
        public static partial class TheShopConstants
        {

            public const string TemplateIdString = "{58872D9E-8C83-4C34-94CF-C580C04B9F56}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);

            public static readonly ID TitleFieldId = TitleConstants.TitleFieldID;
            public const string TitleFieldIdString = TitleConstants.TitleFieldIdString;

            public static readonly ID ContentFieldId = ContentConstants.ContentFieldID;
            public const string ContentFieldIdString = ContentConstants.ContentFieldIdString;

            public static readonly ID ImageFieldId = ImageConstants.ImageFieldID;
            public const string ImageFieldIdString = ImageConstants.ImageFieldIdString;
        }

        public static partial class ProductConstants
        {

            public const string TemplateIdString = "{EFCE9B35-3CFA-4BDA-853D-BF4614B3247F}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string CostFieldIdString = "{91290ABA-E8DD-4020-9A00-E58326408D42}";
            public static readonly ID CostFieldID = new ID(CostFieldIdString);
            public const string CostFieldName = "Cost";


            public const string RatingFieldIdString = "{8260155A-CE0A-450B-BF48-74A5897BE58E}";
            public static readonly ID RatingFieldID = new ID(RatingFieldIdString);
            public const string RatingFieldName = "Rating";

            public static readonly ID TitleFieldId = TitleConstants.TitleFieldID;
            public const string TitleFieldIdString = TitleConstants.TitleFieldIdString;

            public static readonly ID ContentFieldId = ContentConstants.ContentFieldID;
            public const string ContentFieldIdString = ContentConstants.ContentFieldIdString;

            public static readonly ID ImageFieldId = ImageConstants.ImageFieldID;
            public const string ImageFieldIdString = ImageConstants.ImageFieldIdString;
        }
    }
}

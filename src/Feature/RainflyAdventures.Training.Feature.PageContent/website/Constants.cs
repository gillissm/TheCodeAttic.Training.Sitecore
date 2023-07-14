using Sitecore.Data;
using System;
using static RainflyAdventures.Training.Foundation.Core.ModelConstants;

namespace RainflyAdventures.Training.Feature.PageContent
{
    public static class ModelConstants
    {
        public static partial class PromoConstants
        {

            public const string TemplateIdString = "{4851DB88-673A-4136-97CC-79B88BF51A84}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string SubTitleFieldIdString = "{1842E2B7-9CC4-4E1E-8987-38C403715FAD}";
            public static readonly ID SubTitleFieldID = new ID(SubTitleFieldIdString);
            public const string SubTitleFieldName = "SubTitle";

            public const string PrimaryActionLinkFieldIdString = "{7EB0590F-58CD-4B32-AD6D-13D28C2573F7}";
            public static readonly ID PrimaryActionLinkFieldID = new ID(PrimaryActionLinkFieldIdString);
            public const string PrimaryActionLinkFieldName = "PrimaryActionLink";


            public const string SecondaryActionLinkFieldIdString = "{67613673-2460-449A-8B72-EEC2AE197A17}";
            public static readonly ID SecondaryActionLinkFieldID = new ID(SecondaryActionLinkFieldIdString);
            public const string SecondaryActionLinkFieldName = "SecondaryActionLink";

            public static readonly ID TitleFieldId = TitleConstants.TitleFieldID;
            public const string TitleFieldIdString = TitleConstants.TitleFieldIdString;

            public static readonly ID ContentFieldId = ContentConstants.ContentFieldID;
            public const string ContentFieldIdString = ContentConstants.ContentFieldIdString;

            public static readonly ID ImageFieldId = ImageConstants.ImageFieldID;
            public const string ImageFieldIdString = ImageConstants.ImageFieldIdString;
        }
    }
}

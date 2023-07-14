using Sitecore.Data;
using System;

namespace RainflyAdventures.Training.Foundation.Core
{
    public static class ModelConstants
    {

        public static partial class PageMetadataConstants
        {
            public const string TemplateIdString = "B7B48257-0C44-4797-809A-32D1872F9B39";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string MetaDescFieldIdString = "2B54E5F2-2A94-4E65-AD69-744873B7DA1B";
            public static readonly ID MetaDescFieldID = new ID(MetaDescFieldIdString);
            public const string MetaDescFieldName = "MetaDesc";


            public const string MetaKeywordsFieldIdString = "9A18B77D-76C9-4BB0-9E21-9E1593F5344E";
            public static readonly ID MetaKeywordsFieldID = new ID(MetaKeywordsFieldIdString);
            public const string MetaKeywordsFieldName = "MetaKeywords";


            public const string BrowserTitleFieldIdString = "0A209E70-FBB1-4A7A-B468-56F47E2176DC";
            public static readonly ID BrowserTitleFieldID = new ID(BrowserTitleFieldIdString);
            public const string BrowserTitleFieldName = "BrowserTitle";

        }

        public static partial class ContentConstants
        {
            public const string TemplateIdString = "5A864363-5902-4CDB-8421-9B8AE7C1A013";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string ContentFieldIdString = "{7152697D-E946-4EC4-AAD5-223FCC204CE7}";
            public static readonly ID ContentFieldID = new ID(ContentFieldIdString);
            public const string ContentFieldName = "Copy";
        }

        public static partial class ImageConstants
        {

            public const string TemplateIdString = "{B333BDE8-7D00-4BDA-858D-DF45EBA98E7A}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string ImageFieldIdString = "{167E607C-3080-450E-85E0-CD60958456A5}";
            public static readonly ID ImageFieldID = new ID(ImageFieldIdString);
            public const string ImageFieldName = "Image";

        }

        public static partial class PersonSelectorConstants
        {

            public const string TemplateIdString = "{F55A6827-4470-4A2C-9DA4-DBB50F65BEEC}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string PersonFieldIdString = "{5F082DE0-4C20-42CA-AF13-679961996B10}";
            public static readonly ID PersonFieldID = new ID(PersonFieldIdString);
            public const string PersonFieldName = "Person";

        }

        public static partial class StyleableConstants
        {

            public const string TemplateIdString = "{DFD71B66-796C-4BDE-A2BB-B60958D7BAF8}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string BodyCSSFieldIdString = "{D4952280-2D7D-4BF4-A99A-EA36DAD0F0A7}";
            public static readonly ID BodyCSSFieldID = new ID(BodyCSSFieldIdString);
            public const string BodyCSSFieldName = "Body Css Class";


            public const string BodyIdFieldIdString = "{A4960085-5C00-4B39-BA38-CDB43F1D776F}";
            public static readonly ID BodyIdFieldID = new ID(BodyIdFieldIdString);
            public const string BodyIdFieldName = "Body Id";


            public const string TextColorsFieldIdString = "{939239A5-361F-4E10-BB2C-4AB68E3C6800}";
            public static readonly ID TextColorsFieldID = new ID(TextColorsFieldIdString);
            public const string TextColorsFieldName = "TextColors";

            public const string BackgroundPlusTextFieldIdString = "{A246B760-9F0F-4CBB-B43B-1D6F976BE47B}";
            public static readonly ID BackgroundPlusTextFieldID = new ID(BackgroundPlusTextFieldIdString);
            public const string BackgroundPlusTextFieldName = "BackgroundPlusText";

        }

        public static partial class TagSelectorConstants
        {

            public const string TemplateIdString = "{3B0D8A32-ECFC-49FD-8E4D-12C7D6D19958}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);

            public const string TagFieldIdString = "{43139B08-36AE-49CD-BD19-F8694BEA005E}";
            public static readonly ID TagFieldID = new ID(TagFieldIdString);
            public const string TagFieldName = "Tag";

        }

        public static partial class TitleConstants
        {

            public const string TemplateIdString = "{7879CEA4-44EB-498B-9917-0DA4646E1021}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);

            public const string TitleFieldIdString = "{1AB993C6-6E09-4367-AAF2-9372B017910B}";
            public static readonly ID TitleFieldID = new ID(TitleFieldIdString);
            public const string TitleFieldName = "Title";

        }

        public static partial class StyleRenderingParameterConstants
        {

            public const string TemplateIdString = "{9D2FFF6B-4CCC-4E85-A9FC-E4E7F2D1FCA9}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);

        }

        public static partial class TitleImageContent
        {
            public static readonly ID TitleFieldId = TitleConstants.TitleFieldID;
            public const string TitleFieldIdString = TitleConstants.TitleFieldIdString;

            public static readonly ID ContentFieldId = ContentConstants.ContentFieldID;
            public const string ContentFieldIdString = ContentConstants.ContentFieldIdString;

            public static readonly ID ImageFieldId = ImageConstants.ImageFieldID;
            public const string ImageFieldIdString = ImageConstants.ImageFieldIdString;
        }

        public static partial class CSSClassConstants
        {

            public const string TemplateIdString = "{2BB5A4B6-4547-4A73-9528-41C5C26DFD24}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string ClassnameFieldIdString = "{260CFB47-F7EE-4F9C-A8DB-FF98523CAE49}";
            public static readonly ID ClassnameFieldID = new ID(ClassnameFieldIdString);
            public const string ClassnameFieldName = "Classname";

        }
    }
}

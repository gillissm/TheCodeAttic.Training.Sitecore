using Sitecore.Data;
using System;

namespace RainflyAdventures.Training.Feature.Navigation
{
    public static class ModelConstants
    {

        public static partial class HeaderConstants
        {
            public const string TemplateIdString = "{A5CE7EEF-0E8F-41FB-AB97-F4B4B0A8DD1C}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string CompanyLogoFieldIdString = "{72A2F77F-6FE5-4D55-811B-E89ED73E049C}";
            public static readonly ID CompanyLogoFieldID = new ID(CompanyLogoFieldIdString);
            public const string CompanyLogoFieldName = "CompanyLogo";



            public const string WelcomeMessageFieldIdString = "{BC176B2F-FA17-42D2-8DA2-490940073EA0}";
            public static readonly ID WelcomeMessageFieldID = new ID(WelcomeMessageFieldIdString);
            public const string WelcomeMessageFieldName = "WelcomeMessage";

        }

        public static partial class NavigationLinkConstants
        {

            public const string TemplateIdString = "{748FDFA5-9024-4269-B12C-DE23D114E157}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string GoToLinkFieldIdString = "{A1E4E2F7-A935-49B9-9D86-6F1554ABE245}";
            public static readonly ID GoToLinkFieldID = new ID(GoToLinkFieldIdString);
            public const string GoToLinkFieldName = "GoToLink";


            public const string DisplayTitleFieldIdString = "{AC55A0D5-D92C-4C44-B918-2373E243E7D8}";
            public static readonly ID DisplayTitleFieldID = new ID(DisplayTitleFieldIdString);
            public const string DisplayTitleFieldName = "DisplayTitle";
        }

        public static partial class FooterConstants
        {

            public const string TemplateIdString = "{B91BC3B2-20B0-4473-A5F5-971A204B8E35}";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);

            public const string CopyrightMessageFieldIdString = "{DF256563-AD3E-447A-AA26-A19A14440F3E}";
            public static readonly ID CopyrightMessageFieldID = new ID(CopyrightMessageFieldIdString);
            public const string CopyrightMessageFieldName = "CopyrightMessage";


            public const string FooterLogoFieldIdString = "{D1934AA1-F925-4153-860E-0AC64A45F0E3}";
            public static readonly ID FooterLogoFieldID = new ID(FooterLogoFieldIdString);
            public const string FooterLogoFieldName = "FooterLogo";


        }
    }
}

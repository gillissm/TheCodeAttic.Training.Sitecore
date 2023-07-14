using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainflyAdventures.Training.Feature.Product
{
    public static class Constants
    {
        public static class Product
        {

            public const string TemplateIdString = "templateID";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string nameFieldIdString = "FieldID";
            public static readonly ID nameFieldID = new ID(nameFieldIdString);
            public const string nameFieldName = "SitecoreFldName";

        }
    }
}

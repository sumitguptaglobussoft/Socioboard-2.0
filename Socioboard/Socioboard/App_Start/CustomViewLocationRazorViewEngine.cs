using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;






namespace Socioboard.App_Start
{

    /// <summary>
    /// This class 
    /// </summary>
    public class CustomViewLocationRazorViewEngine : RazorViewEngine
    {
        public CustomViewLocationRazorViewEngine()
        {
            ViewLocationFormats = new[] 
        {
            "~/Themes/Socioboard/Views/{1}/{0}.cshtml", "~/Themes/Socioboard/Views/{1}/{0}.vbhtml",
            "~/Themes/Socioboard/Views/Shared/{0}.cshtml", "~/Themes/Socioboard/Views/Shared/{0}.vbhtml"
        };

            MasterLocationFormats = new[] 
        {
            "~/Themes/Socioboard/Views/{1}/{0}.cshtml", "~/Themes/Socioboard/Views/{1}/{0}.vbhtml",
            "~/Themes/Socioboard/Views/Shared/{0}.cshtml", "~/Themes/Socioboard/Views/Shared/{0}.vbhtml"
        };

            PartialViewLocationFormats = new[] 
        {
            "~/Themes/Socioboard/Views/{1}/{0}.cshtml", "~/Themes/Socioboard/Views/{1}/{0}.vbhtml",
            "~/Themes/Socioboard/Views/Shared/{0}.cshtml", "~/Themes/Socioboard/Views/Shared/{0}.vbhtml"
        };
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AMI.MVC.WebApp.App_Start
{
    public class BundleConfig
    {
        public static void Configure(BundleCollection bundles)
        {
            //TODO Configure jQuery and stuff for bundling.
            bundles.Add(new StyleBundle("~/Styles/css").IncludeDirectory("~/Styles", "*.css"));
        }
    }
}
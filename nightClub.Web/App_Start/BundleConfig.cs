using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace nightClub.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            //Bootstrap-icons style
            bundles.Add(new StyleBundle("~/bundles/bootstrap-icons/css").Include(
                "~/Content/vendor/bootstrap-icons/bootstrap-icons.css", new CssRewriteUrlTransform()));
            //Fontsawesome style
            bundles.Add(new StyleBundle("~/bundles/fontawesome/css").Include(
                "~/Content/vendor/fontawesome-free/css/all.min.css", new CssRewriteUrlTransform()));

            //Template Main CSS file
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/Content/main.css", new CssRewriteUrlTransform()));

            //Bootstrap JS Files
 
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/Scripts/bootstrap.bundle.js"));
            bundles.Add(new ScriptBundle("~/bundles/isolate-layout/js").Include(
                "~/Scripts/vendor/isotope-layout/isotope.pkgd.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/validation/js").Include(
                "~/Scripts/vendor/validate.js"));

            //Template Main JS File
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                "~/Scripts/main.js"));

        }
    }
}